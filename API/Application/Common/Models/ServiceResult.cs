﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class ServiceResult<T> : ServiceResult
    {
        public T? Data { get; set; }
        public ServiceResult(T data)
        {
            Data = data;
        }
        public ServiceResult(T data, ServiceError error) : base(error)
        {
            Data = data;
        }

        public ServiceResult(ServiceError error) : base(error)
        {
        }
    }
    public class ServiceResult
    {
        public ServiceResult(ServiceError? error)
        {
            error ??= ServiceError.DefaultError;

            Error = error;
        }

        public ServiceResult() { }
        public string Status => Error is null ? "Success" : "Error";

        public ServiceError? Error { get; set; }

        #region Helper Methods

        public static ServiceResult Failed(ServiceError error)
        {
            return new ServiceResult(error);
        }

        public static ServiceResult<T> Failed<T>(ServiceError error)
        {
            return new ServiceResult<T>(error);
        }

        public static ServiceResult<T> Failed<T>(T data, ServiceError error)
        {
            return new ServiceResult<T>(data, error);
        }

        public static ServiceResult<T> Success<T>(T data)
        {
            return new ServiceResult<T>(data);
        }

        #endregion
    }
}
