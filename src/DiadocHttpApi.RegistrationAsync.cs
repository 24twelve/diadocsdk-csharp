using System.Threading.Tasks;
using Diadoc.Api.Http;
using Diadoc.Api.Proto.Registration;

namespace Diadoc.Api
{
	public partial class DiadocHttpApi
	{
		public Task<RegistrationResponse> RegistrationAsync(string authToken, string boxId, RegistrationRequest registrationRequest)
		{
			var builder = new PathAndQueryBuilder("/Registration");
			builder.AddParameter("boxId", boxId);

			return PerformHttpRequestAsync<RegistrationRequest, RegistrationResponse>(
				authToken,
				builder.BuildPathAndQuery(),
				registrationRequest);
		}

		public Task RegistrationConfirmAsync(string authToken, string boxId, RegistrationConfirmRequest registrationConfirmRequest)
		{
			var builder = new PathAndQueryBuilder("/RegistrationConfirm");
			builder.AddParameter("boxId", boxId);

			return PerformHttpRequestAsync(
				authToken,
				"POST",
				builder.BuildPathAndQuery(),
				Serialize(registrationConfirmRequest));
		}
	}
}