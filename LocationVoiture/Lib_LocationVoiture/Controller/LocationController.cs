using Lib_LocationVoiture.Services;

namespace Lib_LocationVoiture.Controller
{
    public class LocationController
    {
        public ClientsServices      ClientsServices { get; private set; }
        public LoginServices        LoginServices { get; private set; }
        public ModeleServices       ModelesServices { get; private set; }
        public ReservationsServices ReservationsServices { get; private set; }
        public SuccursalesServices  SuccursalesServices { get; private set; }
        public VehiculeServices     VehiculeServices { get; private set; }
        public FabricantsServices   FabricantsService { get; private set; }
        public EmployeServices      EmployesService { get; private set; }
        public TypesServices        TypesService { get; private set; } 
        public LocationsServices    LocationsService { get; set; }

        public LocationController()
        {
            ClientsServices         = new ClientsServices();
            LoginServices           = new LoginServices();
            SuccursalesServices     = new SuccursalesServices();
            VehiculeServices        = new VehiculeServices();
            FabricantsService       = new FabricantsServices();
            ModelesServices         = new ModeleServices();
            ReservationsServices    = new ReservationsServices();
            EmployesService         = new EmployeServices();
            TypesService            = new TypesServices();
            LocationsService        = new LocationsServices();
        }

    }
}
