using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirNautisService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAirNautisService" in both code and config file together.
    [ServiceContract]
    public interface IAirNautisService
    {

        //GET 

        [OperationContract]
        Airplane GetAirplaneById(int airplaneId);

        [OperationContract]
        List<Airplane> GetAllAirplanes();

        [OperationContract]
        List<Travel> GetAirplaneTravels(int airplaneId);

        [OperationContract]
        List<Airplane> GetHangarAirplanes();

        [OperationContract]
        List<Airplane> GetOutAirplanes();

        [OperationContract]
        List<Hangar> GetAllHangars();

        [OperationContract]
        List<Hangar> GetAvaiableHangars();

        [OperationContract]
        List<Airplane> GetActiveAirplanes();

        [OperationContract]
        List<Airplane> GetInactiveAirplanes();

        [OperationContract]
        Hangar GetHangar(int hangar_number);

        [OperationContract]
        List<Airplane> GetAirplanesByHangar(int hangar_number);

        [OperationContract]
        List<Travel> GetTravels();


        //INSERT

        [OperationContract]
        Boolean InsertAirplane(Airplane newAirplane);

        [OperationContract]
        Boolean CreateHangar(Hangar newHangar);

        [OperationContract]
        Boolean NewOutgoingTravel(Travel newTravel);

        [OperationContract]
        Boolean NewIncomingTravel(Travel newTravel);


        //EDIT

        [OperationContract]
        Boolean EditAirplane(Airplane airplane);

        [OperationContract]
        Boolean ActivateAirplane(int airplane_id);

        [OperationContract]
        Boolean DeactivateAirplane(int airplane_id);

    }
}
