﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyExample.Api.Dtos
{
	public class ResponseHeaderDto
	{
		public string ResponseId { get; set; }
		public string SurveyId { get; set; }
		public string UserId { get; set; }
		public DateTime? SubmittedDtm { get; set; }
		public DateTime? CreatedDtm { get; set; }
		public DateTime? LastUpdatedDtm { get; set; }
		public long CountOfAnswers { get; set; }
	}
}
