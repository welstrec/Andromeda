using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Recognition;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MikuDash
{
    public class SpeechRecognizer
    {
    

            public Boolean active = false;
            public Boolean listened = false;
            public Boolean cmdLock = false;
            public int cmdId = 0;
            public String cmdParams;
            private String cdAbrir = "abre";
            private String cdApagar = "apaga";
            private String cdPrender = "prende";
            private String cdSubir = "sube";
            private String cdBajar = "baja";
            private String cdOcultar = "ocúltate";
            private String cdMostrar = "múestrate";
            
            private String cdQuiero = "quiero";
            private String nombre = "Computadora";
            private String cdEscuchar = "Escúchame";
            private String cdNoEscuchar = "desactiva los comandos de voz";

            private String cdEsTodo = "es todo.";


            private String funcPantalla = "las pantallas";
            private String funcVolumen = "el volumen";
            private String funcMute = "silencio";
            private String funcRuido = "ruido";
            public List<String[]> programCmds = new List<String[]>();

            private List<String[]> programs = new List<String[]>();
          

            
            public List<String> cmds;
            public Boolean disableRecognizer = true;

            public List<int> cmdStack = new List<int>();
            Choices colors = new Choices();
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
            DictationGrammar dg = new DictationGrammar();

           
            public SpeechRecognizer()
            {
                try
                {
                    loadPrograms();
                    sre.SetInputToDefaultAudioDevice();
                    String[] sdf = gernerateDictionary();
                    colors.Add(sdf.ToArray());
                    GrammarBuilder grammarBuilder = new GrammarBuilder(colors);
                    Grammar testGrammar = new Grammar(grammarBuilder);
                    sre.LoadGrammar(testGrammar);
                    sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);
                    sre.RecognizeAsync(RecognizeMode.Multiple);
                }
                catch (Exception e)
                {
                }
            }
            public void closeRecognizer(){

                sre.Dispose();
    
            }

            public void loadPrograms()
            {

                int counter = 0;
                string line;

                try
                {
                    System.IO.StreamReader file = new System.IO.StreamReader("programs.ini");
                    while ((line = file.ReadLine()) != null)
                    {
                        String[] tmp = line.Split(';');
                        programs.Add(tmp);
                    }

                    file.Close();
                }
                catch (Exception e)
                {
                    string[] lines = { "gugle;www.google.com;inter", "block de notas;notepad.exe;prog"};
                    // WriteAllLines creates a file, writes a collection of strings to the file, 
                    // and then closes the file.
                    System.IO.File.WriteAllLines(@"programs.ini", lines);
                    programs.Add(("gugle;www.google.com;inter").Split(';'));
                    programs.Add(("block de notas;notepad.exe;prog").Split(';'));

                }

              

            }


            public String[] gernerateDictionary()
            {
                List<String> dict = new List<String>();
                cmds = dict;
                dict.Add(nombre);//0
                dict.Add(cdEsTodo);//1
                dict.Add(cdNoEscuchar);//2

                dict.Add(cdQuiero + " " + funcMute );//3
                
                dict.Add(cdSubir + " " + funcVolumen);//4
                dict.Add(cdBajar + " " + funcVolumen);//5

                dict.Add(cdPrender + " " + funcPantalla);//6
                dict.Add(cdApagar + " " + funcPantalla);//7
                dict.Add(cdOcultar);//8
                dict.Add(cdQuiero + " " + funcRuido);//9
                dict.Add(cdMostrar);
                
                
                for (int i = 0; i < programs.Count; i++)
                {
                    dict.Add(cdAbrir + " " + programs[i][0]);
                }

             


               
                return dict.ToArray();
            }

            public void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
            {
                if (!disableRecognizer)
                {
                    String phrase = "";
                    foreach (RecognizedWordUnit word in e.Result.Words)
                    {
                        phrase += " " + word.Text;
                    }
                    if (!cmdLock)
                    {
                        recognizeCommand(phrase.Trim());
                    }
                }
            }

            public void recognizeCommand(String cmd)
            {

                if (!active && (nombre).Equals(cmd))
                {
                    active = true;
                    listened = true;
                    Console.WriteLine("acts");
                    cmdId = 0;
                }
                else if (active)
                {
                    for (int i = 0; i<cmds.Count ; i++)
                    {
                        if (cmds[i].Equals(cmd) && i != 0 && i != 1 )
                        {
                            if (i < 10)
                            {
                                listened = true;
                                cmdId = i;
                                cmdStack.Add(i);
                                //active = false;
                                Console.WriteLine("rec: " + i);
                                return;
                            }
                            else
                            {
                                foreach (String[] cms in programs)
                                {
                                    
                                    if (cmd.Equals(cdAbrir + " " + cms[0]))
                                    {
                                        cmdId = i;
                                        Console.WriteLine("rec: " + cmd);
                                        programCmds.Add(cms);
                                        return;
                                    }
                                }
                            }
                        }
                    }
                    Console.WriteLine("rec: -1");
                    cmdId = -1;
                    
                    return;
                }
                else if (active && (cdEsTodo).Equals(cmd))
                {
                    
                    cmdId = -1;
                   
                    return;
                }
            }



        }
    
}
