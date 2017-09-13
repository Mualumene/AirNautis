using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AirNautisService
{
    
    public class AirNautisService : IAirNautisService
    {

        public Airplane GetAirplaneById(int airplaneId)
        {
            Airplane a;

            using (AirNautisEntities airNautis = new AirNautisEntities())
            {
                var new_airplane = (from ap in airNautis.Airplane
                              where ap.Id == airplaneId
                              select ap).First();

                a = new Airplane();
                a.Id = new_airplane.Id;
                a.Model = new_airplane.Model;
                a.Year = new_airplane.Year;
                a.Capacity = new_airplane.Capacity;
                a.Hangar = new_airplane.Hangar;

            }
            return a;
        }

        public List<Airplane> GetAllAirplanes()
        {
            List<Airplane> listHangarAirplanes = new List<Airplane>();

            using (AirNautisEntities airNautis = new AirNautisEntities())
            {

                var airplanes = (from a in airNautis.Airplane
                                 select a);

                foreach (Airplane newAirplane in airplanes)
                {
                    Airplane a = new Airplane();
                    a.Id = newAirplane.Id;
                    a.Model = newAirplane.Model;
                    a.Year = newAirplane.Year;
                    a.Capacity = newAirplane.Capacity;
                    a.Hangar = newAirplane.Hangar;
                    a.Active = newAirplane.Active;

                    listHangarAirplanes.Add(a);

                }

            }

            return listHangarAirplanes;
        }

        public List<Travel> GetAirplaneTravels(int airplaneId)
        {
            List<Travel> listTravels = new List<Travel>();

            using (AirNautisEntities airNautis = new AirNautisEntities())
            {

                var travels = (from t in airNautis.Travel
                               where t.Airplane == airplaneId
                               select t);

                foreach (Travel travel in travels)
                {
                    Travel t = new Travel();
                    t.Airplane = travel.Airplane;
                    t.Date = travel.Date;
                    t.Origin = travel.Origin;
                    t.Destination = travel.Destination;

                    listTravels.Add(t);

                }

            }

            return listTravels;
        }


        public List<Airplane> GetHangarAirplanes()
        {
            List<Airplane> listHangarAirplanes = new List<Airplane>();

            using (AirNautisEntities airNautis = new AirNautisEntities())
            {
                
                var airplanes = (from a in airNautis.Airplane
                                 where a.Hangar != null
                                 select a);

                foreach (Airplane newAirplane in airplanes)
                {
                    Airplane a = new Airplane();
                    a.Id = newAirplane.Id;
                    a.Model = newAirplane.Model;
                    a.Year = newAirplane.Year;
                    a.Capacity = newAirplane.Capacity;
                    a.Hangar = newAirplane.Hangar;

                    listHangarAirplanes.Add(a);

                }

            }

            return listHangarAirplanes;
        }


        public List<Airplane> GetOutAirplanes()
        {
            List<Airplane> listOutAirplanes = new List<Airplane>();

            using (AirNautisEntities airNautis = new AirNautisEntities())
            {

                var airplanes = (from a in airNautis.Airplane
                                 where a.Hangar == null && a.Active == true
                                 select a);

                foreach (Airplane newAirplane in airplanes)
                {
                    Airplane a = new Airplane();
                    a.Id = newAirplane.Id;
                    a.Model = newAirplane.Model;
                    a.Year = newAirplane.Year;
                    a.Capacity = newAirplane.Capacity;
                    a.Hangar = newAirplane.Hangar;

                    listOutAirplanes.Add(a);

                }

            }

            return listOutAirplanes;
        }


        public List<Hangar> GetAllHangars()
        {
            List<Hangar> listHangars = new List<Hangar>();

            using (AirNautisEntities airNautis = new AirNautisEntities())
            {

                var hangars = (from h in airNautis.Hangar
                               select h);

                foreach (Hangar hangar in hangars)
                {
                    Hangar h = new Hangar();

                    h.Number = hangar.Number;
                    h.Capacity = hangar.Capacity;

                    listHangars.Add(h);

                }

            }

            return listHangars;
        }


        public Hangar GetHangar(int hangar_number)
        {

            Hangar h;

            using (AirNautisEntities airNautis = new AirNautisEntities())
            {
                var selectedHangar = (from ha in airNautis.Hangar
                                   where ha.Number == hangar_number
                                   select ha).First();

                h = new Hangar();
                h.Number = selectedHangar.Number;
                h.Capacity = selectedHangar.Capacity;

            }

            return h;

        }

        public List<Airplane> GetActiveAirplanes()
        {
            List<Airplane> activeAirplanes = new List<Airplane>();

            using (AirNautisEntities airNautis = new AirNautisEntities())
            {

                var airplanes = (from a in airNautis.Airplane
                                 where a.Active == true
                               select a);

                foreach (Airplane airplane in airplanes)
                {
                    Airplane aa = new Airplane();

                    aa.Id = airplane.Id;
                    aa.Model = airplane.Model;


                    activeAirplanes.Add(aa);

                }

            }

            return activeAirplanes;

        }

        public List<Airplane> GetInactiveAirplanes()
        {
            List<Airplane> inactiveAirplanes = new List<Airplane>();

            using (AirNautisEntities airNautis = new AirNautisEntities())
            {

                var airplanes = (from a in airNautis.Airplane
                                 where a.Active == false
                                 select a);

                foreach (Airplane airplane in airplanes)
                {
                    Airplane aa = new Airplane();

                    aa.Id = airplane.Id;
                    aa.Model = airplane.Model;


                    inactiveAirplanes.Add(aa);

                }

            }

            return inactiveAirplanes;

        }

        public List<Hangar> GetAvaiableHangars()
        {
            List<Hangar> avaiableHangars = new List<Hangar>();

            using (AirNautisEntities airNautis = new AirNautisEntities())
            {
                List<Hangar> allHangars = GetAllHangars();

                foreach (Hangar sHangar in allHangars)
                {
                    int count = GetAirplanesByHangar(sHangar.Number).Count();
                    if (count < sHangar.Capacity)
                    {
                        avaiableHangars.Add(sHangar);
                    }
                }

            }

            return avaiableHangars;
        }

        public List<Airplane> GetAirplanesByHangar(int hangar_number)
        {
            List<Airplane> listHangarAirplane = new List<Airplane>();

            using (AirNautisEntities airNautis = new AirNautisEntities())
            {

                var airplanes = (from ha in airNautis.Airplane
                                    where ha.Hangar == hangar_number
                                    select ha);

                foreach (Airplane airplane in airplanes)
                {
                    Airplane a = new Airplane();

                    a.Id = airplane.Id;
                    a.Model = airplane.Model;
                    a.Year = airplane.Year;
                    a.Capacity = airplane.Capacity;
                    a.Hangar = airplane.Hangar;

                    listHangarAirplane.Add(a);

                }

            }

            return listHangarAirplane;
        }



        public List<Travel> GetTravels()
        {
            List<Travel> listTravels = new List<Travel>();

            using (AirNautisEntities airNautis = new AirNautisEntities())
            {

                var travels = (from t in airNautis.Travel
                               select t);

                foreach (Travel travel in travels)
                {
                    Travel t = new Travel();
                    t.Airplane = travel.Airplane;
                    t.Date = travel.Date;
                    t.Origin = travel.Origin;
                    t.Destination = travel.Destination;

                    listTravels.Add(t);

                }

            }

            return listTravels;
        }



        //INSERT

        public bool InsertAirplane(Airplane newAirplane)
        {
            using (AirNautisEntities airNautis = new AirNautisEntities())
            {

                if (newAirplane.Model != null && newAirplane.Capacity > 0 && newAirplane.Capacity < 1000
                    && newAirplane.Year >= 1970 && newAirplane.Year <= 2013)
                {
                   
                    airNautis.Airplane.Add(newAirplane);
                    airNautis.SaveChanges();
                    return true;
                
                }

            }

            return false;
        }

        public bool CreateHangar(Hangar newHangar)
        {
            using (AirNautisEntities airNautis = new AirNautisEntities())
            {

                if (newHangar.Capacity > 0)
                {

                    airNautis.Hangar.Add(newHangar);
                    airNautis.SaveChanges();
                    return true;

                }

            }

            return false;

        }

        public bool NewOutgoingTravel(Travel newTravel)
        {
            using (AirNautisEntities airNautis = new AirNautisEntities())
            {
                Airplane selectedAirplane = (from ap in airNautis.Airplane
                                             where ap.Id == newTravel.Airplane
                                             select ap).First();

                if (newTravel.Destination != null)
                {
                    
                    Travel travel = new Travel();
                    travel.Date = DateTime.Now;
                    travel.Airplane = selectedAirplane.Id;
                    travel.Origin = "Hangar " + selectedAirplane.Hangar.ToString();
                    travel.Destination = newTravel.Destination;

                    selectedAirplane.Hangar = null;
                    airNautis.SaveChanges();

                    airNautis.Travel.Add(travel);
                    airNautis.SaveChanges();
                    return true;

                }

            }

            return false;
        }

        public bool NewIncomingTravel(Travel newTravel)
        {

            using (AirNautisEntities airNautis = new AirNautisEntities())
            {
                Airplane selectedAirplane = (from ap in airNautis.Airplane
                                             where ap.Id == newTravel.Airplane
                                             select ap).First();

                Hangar selectedHangar = GetHangar(int.Parse(newTravel.Destination));

                int counter = GetAirplanesByHangar(int.Parse(newTravel.Destination)).Count();

                if (counter < selectedHangar.Capacity)
                {
                    
                    
                    Travel travel = new Travel();
                    travel.Date = DateTime.Now;
                    travel.Airplane = selectedAirplane.Id;
                    travel.Origin = newTravel.Origin;
                    travel.Destination = "Hangar " + selectedHangar.Number.ToString();


                    selectedAirplane.Hangar = selectedHangar.Number;
                    airNautis.SaveChanges();

                    airNautis.Travel.Add(travel);
                    airNautis.SaveChanges();
                    return true;

                } 
            
            }

            return false;
        }

        //EDIT

        public Boolean EditAirplane(Airplane airplane)
        {

            using (AirNautisEntities airNautis = new AirNautisEntities())
            {
                Airplane a = (from ap in airNautis.Airplane
                                   where ap.Id == airplane.Id
                                   select ap).First();

                if (airplane.Model != null && airplane.Capacity > 0 && airplane.Capacity < 1000
                    && airplane.Year >= 1970 && airplane.Year <= 2013)
                {
                    a.Model = airplane.Model;
                    a.Year = airplane.Year;
                    a.Capacity = airplane.Capacity;
                    a.Hangar = airplane.Hangar;

                    airNautis.SaveChanges();
                    return true;
                }
                              
            }

            return false;
        }



        public bool ActivateAirplane(int airplane_id)
        {
            using (AirNautisEntities airNautis = new AirNautisEntities())
            {
                Airplane a = (from ap in airNautis.Airplane
                              where ap.Id == airplane_id
                              select ap).First();

                if (a != null)
                {
                    a.Active = true;

                    airNautis.SaveChanges();
                    return true;
                }

            }

            return false;
        }

        public bool DeactivateAirplane(int airplane_id)
        {
            using (AirNautisEntities airNautis = new AirNautisEntities())
            {
                Airplane a = (from ap in airNautis.Airplane
                              where ap.Id == airplane_id
                              select ap).First();

                if (a != null)
                {
                    a.Active = false;
                    a.Hangar = null;

                    airNautis.SaveChanges();
                    return true;
                }

            }

            return false;
        }
    }
}
