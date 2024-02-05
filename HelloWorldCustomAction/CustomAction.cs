using System.IO;
using WixToolset.Dtf.WindowsInstaller;

namespace HelloWorldCustomAction
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult WriteFileCustomAction(Session session)
        {
            session.Log("Begin WriteFileCustomAction");
            string installDir = session.CustomActionData["InstallDir"];
            File.WriteAllText(Path.Combine(installDir, "CustomAction.txt"), "Custom Action");
            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult CleanFileCustomAction(Session session)
        {
            session.Log("Begin CleanFileCustomAction");
            string installDir = session.CustomActionData["InstallDir"];
            string customActionFile = Path.Combine(installDir, "CustomAction.txt");
            if (File.Exists(customActionFile))
            {
                File.Delete(customActionFile);
            }

            return ActionResult.Success;
        }
    }
}
