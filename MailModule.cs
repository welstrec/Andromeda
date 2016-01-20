using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Threading;

using S22.Imap;
using System.Net.Mail;
using System.Windows.Media;
using System.Windows.Threading;
using MikuDash;
namespace Andromeda
{
    public class MailModule
    {


        public static int MAIL_UPD_INTERVAL = 300000;//En MS
        public static int MAIL_ERR_UPD_INTERVAL = 2000;//En MS
        private List<String> miCorreo;
        private List<String> contra;
        private List<String> imapHost;
        private List<int> imapPort;

        private long oldUids = 0;
        private long oldUidslast = 0;

        public List<String> listaRecividostemp = new List<String>();
        public List<uint> mensajes = new List<uint>();
        public Boolean mailActive = false;
        ImapClient session;
        private DateSound stat;
        //public VentanaMensajesCorreo vmc;
        private MikuDashMain main;

        public String latestSubject;
        public String latestSender;

        public MailModule(MikuDashMain main, DateSound roostUpdate, List<String> imapHost, List<int> imapPort, List<String> correo, List<String> pwd)
        {
            this.imapPort = imapPort;
            this.imapHost = imapHost;
            this.miCorreo = correo;
            this.contra = pwd;
            this.stat = roostUpdate;
            this.main = main;
            

        }

        
       

        public delegate void updateMail(String num,Boolean newone,Boolean notify,String info);

        public void actualizarMensajesSinLeer()
        {

            while (mailActive)
            {
                
                try
                {
                    long newCount = 0;
                    uint latest=0;
                    main.loadMailSettings(null, imapHost, imapPort, miCorreo, contra);
                    for (int i = 0; i < imapHost.Count; i++)
                    {

                        session = new ImapClient(imapHost[i], imapPort[i], miCorreo[i], contra[i], AuthMethod.Login, true);
                        IList<uint> newUids = (IList<uint>)session.Search(SearchCondition.Unseen().And(SearchCondition.SentSince(DateTime.Today.AddDays(-16.0))));
                        if (newUids.Count > 0)
                        {
                            latest = newUids.Last();
                            newCount += newUids.Count;
                        }
                        
                        
                    }

                    if (oldUids == 0)
                    {
                        oldUids = newCount;
                        oldUidslast = newCount;
                    }

                    if (newCount > oldUids)
                    {
                        MailMessage msg = session.GetMessage(latest, FetchOptions.HeadersOnly, false);
                        stat.BeginInvoke(new updateMail(stat.updateMail), new Object[] { "" + newCount, true, newCount>oldUidslast, msg.From.User + "\nNew Mail!" });
                        
                        
                    }
                    else if (newCount <= oldUids)
                    {
                        stat.BeginInvoke(new updateMail(stat.updateMail), new Object[] { ""+newCount, false,false,"" });
                        oldUids = newCount;
                    }
                    oldUidslast = newCount;
                    session.Dispose();
                    Thread.Sleep(MAIL_UPD_INTERVAL);


                }
                catch (Exception e)
                {
                    stat.BeginInvoke(new updateMail(stat.updateMail), new Object[] {"ERR", true,false,"" });
                    Thread.Sleep(MAIL_ERR_UPD_INTERVAL);
                    Console.WriteLine(e);
                    
                }
                
            }
        }



        public void getMessages()
        {
            /*session = new ImapClient(imapHost, imapPort, miCorreo, contra, AuthMethod.Login, true);
            IList<uint> newUids = (IList<uint>)session.Search(SearchCondition.All().And(SearchCondition.SentSince(DateTime.Today.AddDays(-1))));


            foreach (uint id in newUids)
            {
                Console.WriteLine("FETCH: "+ id);
                MailMessage msg = session.GetMessage(id,FetchOptions.HeadersOnly,false);
                listaRecividostemp.Add("["+msg.Sender+"]"+msg.Subject);
                mensajes.Add(id);
            }

            vmc.OnLoadedMessages();
             * */
            

        }

        public String getMessageBody(uint msg)
        {
            MailMessage msgb = session.GetMessage(msg, FetchOptions.Normal, false);
            return msgb.Body;
        }
    }
}
