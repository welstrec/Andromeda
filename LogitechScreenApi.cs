using System;
using System.Collections.Generic;
using System.Drawing;
using Andromeda.logilcd;
namespace Andromeda
{
    class LogitechScreenApi
    {


        private LogiLcd logilcd = new LogiLcd();

        Bitmap LCD;

        public LogitechScreenApi()
        {
            initialize();
            screenSaver();
        }

        private void initialize()
        {
            if (!logilcd.Initialize("Andromeda", LCD_TYPE.MONO | LCD_TYPE.COLOR))
            {
               
                logilcd.Shutdown();
            }
            else
            {
                LCD = new Bitmap(160, 43);
            }
        }


        public void disconect()
        {
            logilcd.Shutdown();
        }

        //Not used in this example
        public void btnCallbackB(int deviceType, int dwButtons)
        {
           
        }

        public void screenSaver()
        {
            Font sFont = new Font("Arial", 24, GraphicsUnit.Pixel);

            Graphics g = Graphics.FromImage(LCD);
            g.Clear(Color.White);
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;


            g.DrawString("ANDROMEDA", sFont, SystemBrushes.WindowText, 0, 0);
            g.DrawString("<Please Stand by>", new Font("Arial", 12, GraphicsUnit.Pixel), SystemBrushes.WindowText, 25, 25);
            



            logilcd.SetMonoBackground(imageToByteArray(LCD));

            logilcd.Update();
        }

        public void updateMonitorLCD(List<CUMonitorUpdate> monitorUpd)
        {
            Font sFont = new Font("Arial", 9, GraphicsUnit.Pixel);
           
                Graphics g = Graphics.FromImage(LCD);
                g.Clear(Color.White);
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), new Rectangle(0, 0, 28, 10));
                g.DrawString("Devic.", sFont, Brushes.White, -1, 0);
                g.DrawString("Proc", sFont, SystemBrushes.WindowText, 29, 0);
                g.DrawString("°C", sFont, SystemBrushes.WindowText, 53, 0);
                g.DrawString("Ram", sFont, SystemBrushes.WindowText, 73, 0);
                g.DrawString("Mhz", sFont, SystemBrushes.WindowText, 99, 0);

                int ln = 1;
                foreach (CUMonitorUpdate mn in monitorUpd)
                {
                    drawLineOnTable(g, mn, ln);
                    ln++;
                }



            
                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black), 0, 0, 120, 0);
                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black), 0, 10, 120, 10);
                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black), 0, 20, 120, 20);
                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black), 0, 30, 120, 30);
                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black), 0, 40, 120, 40);

                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black), 0, 0,0, 40);
                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black),28,0,28,40);
                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black), 50, 0, 50, 40);
                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black), 72, 0, 72, 40);
                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black), 96, 0, 96, 40);
                    g.DrawLine(new System.Drawing.Pen(System.Drawing.Color.Black), 120, 0, 120, 40);

                    g.Dispose();
                    sFont.Dispose();

                  
                    logilcd.SetMonoBackground(imageToByteArray(LCD));
                  
                    logilcd.Update();
                   
                    //LogitechScreenApi.LcdUpdateBitmap(device, LCD.GetHbitmap(), LogitechScreenApi.LGLCD_DEVICE_BW);
         
                

                
              
            
            

        }

        public void drawLineOnTable(Graphics table,CUMonitorUpdate dev, int lin)
        {
            Font sFont = new Font("Arial", 9, GraphicsUnit.Pixel);
            table.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black),new Rectangle(0,lin*10,28,10));
            table.DrawString(dev.devName, sFont, Brushes.White, 0, lin*10);
            table.DrawString("" + dev.load.ToString("D3"), sFont, SystemBrushes.WindowText, 31, lin * 10);
            table.DrawString("" + dev.temp.ToString("D3"), sFont, SystemBrushes.WindowText, 52, lin * 10);
            table.DrawString("" + dev.ramUsage.ToString("D3"), sFont, SystemBrushes.WindowText, 76, lin * 10);
            table.DrawString("" + dev.clk.ToString("D4"), sFont, SystemBrushes.WindowText, 97, lin * 10);
        }
        public byte[] imageToByteArray(Bitmap imageIn)
        {
            byte[] matrix = new byte[imageIn.Width * imageIn.Height * 8];
            int mtrxPtr = 0;
            for (int i = 0; i < imageIn.Height;i++ )
            {
                for (int j = 0; j < imageIn.Width; j++)
                {
                    
                    if (imageIn.GetPixel(j, i).R == 0 && imageIn.GetPixel(j, i).G == 0 && imageIn.GetPixel(j, i).B == 0)
                    {
                        matrix[mtrxPtr] = Byte.MaxValue;
                    }
                    else
                    {
                        matrix[mtrxPtr] = Byte.MinValue;
                    }
                    mtrxPtr++;
                }
            }
            return matrix;
        }
        private void drawCircleText(Graphics g, int x, int y, int r, string txt, Font fnt, Brush brush)
        {
            //make circle with radius r and center at x, y
            Rectangle rec = new Rectangle(x-r, y-r, r*2, r*2);
            Pen p = new Pen(brush);
            g.DrawEllipse(p, rec);

            SizeF txtSize = g.MeasureString(txt, fnt);
            g.DrawString(txt, fnt, brush, x - (txtSize.Width / 2) + 1, y - (txtSize.Height / 2) + 1);

            p.Dispose();
        }
    }
}
