﻿namespace TravelBookingFrance.DTO.DTOs;

public class UserToReturnDTO
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public bool IsAuthenticated { get; set; }
    public string Token { get; set; }
}
