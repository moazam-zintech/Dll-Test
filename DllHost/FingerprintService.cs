using libzkfpcsharp;

namespace TestCodeCompiler
{
    public class FingerprintService
    {
        public FingerprintService()
        {
            int ret = zkfp2.Init();
            if (ret == zkfp.ZKFP_ERR_OK)
            {
                Console.WriteLine("SDK initialized successfully.");
            }
            else
            {
                Console.WriteLine($"SDK initialization failed with error code: {ret}");
            }
        }
        ~FingerprintService()
        {
            zkfp2.Terminate();
        }
    }
}

