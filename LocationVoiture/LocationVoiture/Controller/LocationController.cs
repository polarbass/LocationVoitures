using LocationVoiture.Model;
using LocationVoiture.Services;

namespace LocationVoiture.Controller
{
    class LocationController
    {
        private locationvoitureEntities entitie { get; set; }

        public ClientsServices      ClientsServices { get; private set; }
        public LoginServices        LoginServices { get; set; }
        public ModeleServices       ModelesServices { get; set; }
        public ReservationsServices ReservationsServices { get; set; }
        public SuccursalesServices  SuccursalesServices { get; set; }
        public VehiculeServices     VehiculeServices { get; set; }
        public FabricantsServices   FabricantsService { get; set; }
        public EmployeServices      EmployesService { get; set; }
        public TypesServices        TypesService { get; set; } 

        public LocationController()
        {
            ClientsServices         = new ClientsServices(new locationvoitureEntities());
            LoginServices           = new LoginServices(new locationvoitureEntities());
            SuccursalesServices     = new SuccursalesServices(new locationvoitureEntities());
            VehiculeServices        = new VehiculeServices();
            FabricantsService       = new FabricantsServices();
            ModelesServices         = new ModeleServices();
            ReservationsServices    = new ReservationsServices();
            EmployesService         = new EmployeServices();
            TypesService            = new TypesServices();
        }


    }
}
