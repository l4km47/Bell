namespace RcisSchoolBell.lib.UHWID
{
    public class UhwidEngine
    {
        public string SimpleUid { get; private set; }

        public string AdvancedUid { get; private set; }

        public UhwidEngine()
        {
            DoUniqueId();
        }
        private void DoUniqueId()
        {
            var volumeSerial = DiskId.GetDiskId();
            var cpuId = CpuId.GetCpuId();
            var windowsId = WindowsId.GetWindowsId();
            SimpleUid = volumeSerial + cpuId;
            AdvancedUid = SimpleUid + windowsId;
        }
    }
}
