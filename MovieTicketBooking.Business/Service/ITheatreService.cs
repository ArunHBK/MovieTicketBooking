﻿using MovieTicketBooking.Data.Models;


namespace MovieTicketBooking.Business.Service
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITheatreService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<Theatre>> GetTheatre();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Theatre> GetTheatre(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<PrepareResponse> AddTheatre(TheatreDto data);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        Task<PrepareResponse> UpdateTheatre(TheatreDto data, string id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<PrepareResponse> DeleteTheatre(string id);
    }
}
