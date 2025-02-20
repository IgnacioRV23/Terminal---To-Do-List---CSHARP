namespace app
{
    //Create art with: https://www.asciiart.eu/text-to-ascii-art
    class textArt
    {
        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
            +===================================================================================================+
            |__        __   _                            _____         _      ____            _                 |
            |\ \      / /__| | ___ ___  _ __ ___   ___  |_   _|_ _ ___| | __ / ___| _   _ ___| |_ ___ _ __ ___  |
            | \ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \   | |/ _` / __| |/ / \___ \| | | / __| __/ _ \ '_ ` _ \ |
            |  \ V  V /  __/ | (_| (_) | | | | | |  __/   | | (_| \__ \   <   ___) | |_| \__ \ ||  __/ | | | | ||
            |   \_/\_/ \___|_|\___\___/|_| |_| |_|\___|   |_|\__,_|___/_|\_\ |____/ \__, |___/\__\___|_| |_| |_||
            |                                                                       |___/                       |
            +===================================================================================================+
            ");
            Console.ResetColor();
        }

        public static void Bye()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
            +=============================================================+
            |    ____                 _   ____                       __   |
            |   / ___| ___   ___   __| | | __ ) _   _  ___        _  \ \  |
            |  | |  _ / _ \ / _ \ / _` | |  _ \| | | |/ _ \      (_)  | | |
            |  | |_| | (_) | (_) | (_| | | |_) | |_| |  __/       _   | | |
            |   \____|\___/ \___/ \__,_| |____/ \__, |\___|      (_)  | | |
            |                                   |___/                /_/  |
            +=============================================================+
            ");
            Console.ResetColor();
        }
        public static void SuccessMsg(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static void ErrorMsg(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static void WarningMsg(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static void QuestionMsg(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}