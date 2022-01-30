using System.Collections.Generic;
using UnityEngine;

namespace Unity_LoggerHelper
{
    public static class LoggerHelper
    {
        private static readonly HashSet<object> loggedMessages = new HashSet<object>();

        /// <summary>
        /// Identical to Debug.Log, but will only log the message once
        /// </summary>
        public static void LogOnce(object message) {
            if (loggedMessages.Contains(message)) return;
            loggedMessages.Add(message);
            
            Debug.Log(message);
        }
        
        /// <summary>
        /// Identical to Debug.Log, but will only log the message once, does not check context for differences
        /// </summary>
        public static void LogOnce(object message, Object context) {
            if (loggedMessages.Contains(message)) return;
            loggedMessages.Add(message);
            
            Debug.Log(message, context);
        }
    }
}