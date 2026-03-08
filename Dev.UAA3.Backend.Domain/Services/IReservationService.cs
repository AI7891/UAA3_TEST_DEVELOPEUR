using Dev.UAA3.Backend.Domain.Models;

namespace Dev.UAA3.Backend.Domain.Services
{
    public interface IReservationService
    {
        Reservation Create(Reservation reservation);
        bool Cancel(int  reservationId);

        IEnumerable<Reservation> GetMemberReservations();
        IEnumerable<Reservation> GetRoomReservations();
    }
}
