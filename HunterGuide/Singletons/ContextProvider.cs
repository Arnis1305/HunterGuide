using HunterGuide.EF;

namespace HunterGuide.Singletons
{
    public class ContextProvider
    {
        private static ContextProvider provider;
        private readonly ApplicationContext context;

        private ContextProvider()
        {
            context = new ApplicationContext();
        }

        public static ApplicationContext GetApplicationContext()
        {
            if (provider == null)
            {
                provider = new ContextProvider();
            }
            return provider.context;
        }

        public static void Dispose() 
        {
            if (provider == null) 
            {
                return;
            }
            provider.context.Dispose();
        }
    }
}
