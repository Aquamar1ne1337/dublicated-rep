using System.IO;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace Userinyerface.Utilities
{
    public static class SimulationUtil
    {
        private static InputSimulator simulator = new InputSimulator();

        public static void UploadImage(string imagePath)
        {
            FileInfo fileInfo = new FileInfo(imagePath);
            simulator.Keyboard.TextEntry(fileInfo.FullName);
            Thread.Sleep(1500);
            simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
        }
    }
}