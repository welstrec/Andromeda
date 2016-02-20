using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andromeda
{
    class HWMonitor
    {
        Computer cpt;
        private List<IHardware> pcCompatibleHardware = new List<IHardware>();
        
        public void initialize()
        {
            cpt = new Computer() { MainboardEnabled = true, GPUEnabled = true, CPUEnabled = true };
            cpt.Open();
            pcCompatibleHardware = new List<IHardware>();

            foreach (var hardwareItem in cpt.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.GpuNvidia || hardwareItem.HardwareType == HardwareType.GpuAti)
                {
                    pcCompatibleHardware.Add(hardwareItem);
                    hardwareItem.Update();

                }
                if (hardwareItem.HardwareType == HardwareType.RAM)
                {
                    pcCompatibleHardware.Add(hardwareItem);
                    hardwareItem.Update();

                }
                if (hardwareItem.HardwareType == HardwareType.CPU)
                {
                    pcCompatibleHardware.Add(hardwareItem);
                    hardwareItem.Update();

                }


            }
        }
        public List<CUMonitorUpdate> updateHardwareStats()
        {
            List<CUMonitorUpdate> upd = new List<CUMonitorUpdate>();
            int gpuCount = 1;
            int cpuCount = 1;
         
            if (cpt != null)
            {
                foreach (IHardware hw in pcCompatibleHardware)
                {
                    if (hw.HardwareType == HardwareType.GpuNvidia || hw.HardwareType == HardwareType.GpuAti)
                    {
                        CUMonitorUpdate updToc = new CUMonitorUpdate();
                        hw.Update();
                        foreach (IHardware subHardware in hw.SubHardware)
                            subHardware.Update();

                        foreach (var sensor in hw.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Clock && sensor.Name.ToLower().Contains("core"))
                            {

                                updToc.clk = sensor.Value.HasValue ? (Convert.ToInt32(sensor.Value)) : 1;


                            }

                            if (sensor.SensorType == SensorType.Temperature && sensor.Name.ToLower().Contains("core"))
                            {

                                updToc.temp = sensor.Value.HasValue ? Convert.ToInt32(sensor.Value) : 1;


                            }


                            if (sensor.SensorType == SensorType.Load && sensor.Name.ToLower().Contains("core"))
                            {

                                updToc.load = sensor.Value.HasValue ? Convert.ToInt32(sensor.Value) : 1;


                            }
                            if (sensor.SensorType == SensorType.Load && sensor.Name.ToLower().Contains("memory"))
                            {

                                updToc.ramUsage = sensor.Value.HasValue ? Convert.ToInt32(sensor.Value) : 1;


                            }
                        }
                        updToc.devName = "GPU" + gpuCount;
                        upd.Add(updToc);
                        gpuCount++;
                    }

                    if (hw.HardwareType == HardwareType.CPU)
                    {
                        CUMonitorUpdate updToc = new CUMonitorUpdate();
                        hw.Update();
                        int cpuclkThick = 0;
                        int cpuclkcounter = 0;
                        foreach (IHardware subHardware in hw.SubHardware)
                        {
                            subHardware.Update();
                        }
                            


                            
                            foreach (var sensor in hw.Sensors)
                            {
                                
                               
                                if (sensor.SensorType == SensorType.Clock && sensor.Name.ToLower().Contains("core"))
                                {

                                    cpuclkThick += sensor.Value.HasValue ? (Convert.ToInt32(sensor.Value)) : 1;
                                    cpuclkcounter = sensor.Value.HasValue ? cpuclkcounter + 1 : 1;

                                }


                                if (sensor.SensorType == SensorType.Load && sensor.Name.ToLower().Contains("total"))
                                {

                                    updToc.load = sensor.Value.HasValue ? Convert.ToInt32(sensor.Value) : 1;


                                }
                                if (sensor.SensorType == SensorType.Temperature && sensor.Name.ToLower().Contains("package"))
                                {

                                    updToc.temp = sensor.Value.HasValue ? Convert.ToInt32(sensor.Value) : 1;


                                }

                            }
                        
                        updToc.clk = (cpuclkThick / cpuclkcounter);
                        updToc.devName = "CPU" + cpuCount;
                        updToc.ramUsage = Convert.ToInt32(new PerformanceCounter("Memory", "% Committed Bytes In Use", true).NextValue());

                        upd.Add(updToc);
                        cpuCount++;
                    }




                }
            }
            

            return upd;
        }


        public void disposeMonitor()
        {
            if (cpt != null)
            {
                cpt.Close();
            }
        }
    }
}
