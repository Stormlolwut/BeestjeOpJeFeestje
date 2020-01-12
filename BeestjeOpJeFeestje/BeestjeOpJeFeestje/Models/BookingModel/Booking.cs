﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeestjeOpJeFeestje.Models
{
	public class Booking
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ID { get; set; }

		[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
		[DataType(DataType.Date)]
		public DateTime Date { get; set; }
		
		[DisplayFormat(DataFormatString = "{0:n} €")]
		public double TotalPrice { get; set; }

		[NotMapped] public BookingState BookingState { get; set; } = BookingState.Animals;

		public Booking()
		{
		}

		public List<BookingAnimal> BookingAnimals { get; set; }
		public List<BookingAccessories> BookingAccessories { get; set; }

		public int ClientInfoId { get; set; }
		public ClientInfo ClientInfo { get; set; }
	}
}