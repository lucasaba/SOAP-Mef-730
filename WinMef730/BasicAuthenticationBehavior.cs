using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace WinMef730
{
    class BasicAuthenticationBehavior : System.ServiceModel.Description.IEndpointBehavior
    {
        private string username;
        private string password;

        public BasicAuthenticationBehavior(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public void AddBindingParameters(ServiceEndpoint endpoint, BindingParameterCollection bindingParameters)
        {
            return;
        }

        public void ApplyClientBehavior(ServiceEndpoint endpoint, ClientRuntime clientRuntime)
        {
            clientRuntime.MessageInspectors.Add(new BasicAuthenticationInspector(this.username, this.password));
        }

        public void ApplyDispatchBehavior(ServiceEndpoint endpoint, EndpointDispatcher endpointDispatcher)
        {
            return;
        }

        public void Validate(ServiceEndpoint endpoint)
        {
            return;
        }
    }

    class BasicAuthenticationInspector : System.ServiceModel.Dispatcher.IClientMessageInspector
    {
        private string authorization;

        public BasicAuthenticationInspector(string username, string password)
        {
            this.authorization = "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes(String.Format("{0}:{1}", username, password)));
        }

        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            return;
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            HttpRequestMessageProperty richiesta = request.Properties.Values.OfType<HttpRequestMessageProperty>().FirstOrDefault();

            if (richiesta != null)
            {
                richiesta.Headers.Add("Authorization", this.authorization);
            } else {
                richiesta = new HttpRequestMessageProperty();
                richiesta.Headers.Add("Authorization", this.authorization);
                request.Properties.Add(HttpRequestMessageProperty.Name, richiesta);
            }

            return request;
        }
    }
}
