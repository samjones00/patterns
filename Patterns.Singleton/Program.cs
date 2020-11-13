using System;

namespace Patterns.Singleton
{
    class Program
    {
        //lazy singleton
        private static readonly Lazy<SingletonClass> lazySingletonClass = new Lazy<SingletonClass>(() => new SingletonClass());

        public static SingletonClass LazySingletonClass => lazySingletonClass.Value;

        //shortened singleton
        private static SingletonClass _shortenedingletonClass;
        private static readonly SingletonClass ShortenedSingletonClass = _shortenedingletonClass ?? new SingletonClass();

        //classic singleton
        private static SingletonClass _singletonClass;
        private static SingletonClass SingletonClass
        {
            get
            {
                if (_singletonClass == null)
                {
                    _singletonClass = new SingletonClass();
                    return _singletonClass;
                }

                return _singletonClass;
            }
        }

        static void Main(string[] args)
        {
            var singleton = SingletonClass;
            singleton.DoAction();

            var shortenedSingleton = ShortenedSingletonClass;
            shortenedSingleton.DoAction();

            var lazySingleton = LazySingletonClass;
            lazySingleton.DoAction();

            lazySingleton.DoAction();
        }
    }
}
