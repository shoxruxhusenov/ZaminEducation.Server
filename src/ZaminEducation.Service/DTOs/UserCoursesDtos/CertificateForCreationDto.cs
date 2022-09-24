﻿using ZaminEducation.Service.DTOs.CoursesDtos;
using ZaminEducation.Service.DTOs.UsersDtos;

namespace ZaminEducation.Service.DTOs.UserCoursesDtos
{
    public class CertificateForCreationDto
    {
        public CourseForCreationDto Course { get; set; }

        public UserForCreationDto User { get; set; }
    }
}
