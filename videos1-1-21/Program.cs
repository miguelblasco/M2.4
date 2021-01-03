using System;

namespace ConsoleApp4  //vídeo: 32 -> minuto: 7:43. Como crear varios ficheros fuente
{
    class Program
    {
        static void Main(string[] args)
        {
                   

            do
            {
                Console.WriteLine("Elige opción: \n \n  1.Darse alta \n  2.Identificarse \n");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        DarseAlta();
                        break;
                    case 2:
                        Identificarse();
                        break;
                }
                //  CrearVideo();
            } while (Console.ReadKey().Key == ConsoleKey.Enter);







            do
            {


                Console.WriteLine("Elige opción: \n \n  1.añadir tag \n  2.reproducir \n  3.pausar \n  4.parar");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("-Introduce tag");
                        //miVideo.listTag = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("-Empieza reproducción");
                        do
                        {
                            Console.WriteLine("reproduciendo vídeo");
                            Console.WriteLine("apretar cualquier tecla para salir excepto enter");
                        } while (Console.ReadKey().Key == ConsoleKey.Enter);

                        break;
                    case 3:
                        Console.WriteLine("-Vídeo pausado");
                        do
                        {
                            Console.WriteLine("apretar cualquier tecla para salir excepto enter");
                        } while (Console.ReadKey().Key == ConsoleKey.Enter);

                        break;
                    case 4:
                        Console.WriteLine("-Vídeo parado");
                        break;


                }
            } while (Console.ReadKey().Key != ConsoleKey.Enter);







        }

        static void DarseAlta()
        {
            User miUser;
            miUser = new User();

            Console.WriteLine("Darse de alta: \n");

            Console.WriteLine(">Introduce usuario");
            try
            {
                
                miUser.user = Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("No puede estar vacío");
            }

            Console.WriteLine("\n");
            Console.WriteLine(">Introduce nombre");
            try
            {
                miUser.name = Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("No puede estar vacío");
            }

            Console.WriteLine("\n");
            Console.WriteLine(">Introduce apellido");
            try
            {
                miUser.surname = Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("No puede estar vacío");
            }

            Console.WriteLine("\n");
            Console.WriteLine(">Introduce password");
            try
            {
                miUser.password = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {


                Console.WriteLine("introduce números únicamente");
                miUser.password = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\n");
            Console.WriteLine(">Introduce fecha");
            try
            {
                miUser.date = int.Parse(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("No puede estar vacío");
            }

            

        }

        static void Identificarse()
        {
            // user miUser;
            //  miUser = new user();



            Console.WriteLine("introduce usuario");
            try
            {
                string user = Console.ReadLine();
                // miUser.newUser = Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("No puede estar vacío");
            }

            Console.WriteLine("introduce password");
            try
            {
               string password = Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("No puede estar vacío");
            }

            Video miVideo;
            miVideo = new Video();


            Console.WriteLine("\n\n");
            miVideo.CrearVideo();

        }

    }

    class User

    {
      
        public string user;
        public string name;
        public string surname;
        public int password;
        public int date;



    }

    class Video
    {
       
        public string url;
        public string title;
        public string listTag;

       
        public  void CrearVideo()
        {
            Console.WriteLine("Crea vídeo \n");

            Video miVideo;
            miVideo = new Video();

            Console.WriteLine("introduce url:");
            miVideo.url = Console.ReadLine();
            Console.WriteLine("introduce título:");
            miVideo.title = Console.ReadLine();
            Console.WriteLine("introduce tag:");
            miVideo.listTag = Console.ReadLine();
        }


    }
}
