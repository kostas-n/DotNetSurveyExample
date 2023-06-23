﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyExample.Domain.Aggregates.Surveys
{
	public class RadioQuestion : Question
	{
		public override string QuestionType => "radio";
		public List<QuestionOption> QuestionOptions { get; set; }
	}
}
