using System;
using SiliconStudio.Paradox.Graphics;
using Varus.Paradox.Console.PythonInterpreter;

namespace Varus.Paradox.Console.Sample
{
    class ConsoleApp
    {
        static void Main(string[] args)
        {
            var pythonInterpreter = new PythonCommandInterpreter();

            // Add path to IronPython standard library.
            pythonInterpreter.AddSearchPath(AppDomain.CurrentDomain.BaseDirectory);

            // Import threading module and Timer function.
            pythonInterpreter.RunScript("import threading");
            pythonInterpreter.RunScript("from threading import Timer");

            // Define types to load after game has been loaded.
            Action<Console, Cube, SpriteFont, SpriteFont> postLoad = (console, cube, font1, font2) =>
            {
                pythonInterpreter.AddVariable("cube", cube);
                pythonInterpreter.AddVariable("console", console);
                pythonInterpreter.AddVariable("font1", font1);
                pythonInterpreter.AddVariable("font2", font2);                
            };            

            using (var game = new ConsoleGame(pythonInterpreter, postLoad))
            {
                game.Run();
            }
        }
    }
}
