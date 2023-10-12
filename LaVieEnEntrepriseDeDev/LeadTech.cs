namespace LaVieEnEntrepriseDeDev
{
    internal delegate Code CreateCodeAvecProcess();

    internal class LeadTech
    {

        public CreateCodeAvecProcess GetProcedure()
        {
            CreateCodeAvecProcess delegateAEnvoyer = () => new Code("namespace Coucou; public class JeTaiBienEu {}");

            return delegateAEnvoyer;
        }

        //public CreateCodeAvecProcess GetProcedure()
        //{
        //    return () => new Code("namespace Coucou; public class JeTaiBienEu {}");
        //}

        // public CreateCodeAvecProcess GetProcedure() => () => new Code("namespace Coucou; public class JeTaiBienEu {}");

    }
}
