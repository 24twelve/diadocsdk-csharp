using Diadoc.Api.Http;
using Diadoc.Api.Proto.Registration;

namespace Diadoc.Api
{
	public partial class DiadocHttpApi
	{
		public RegistrationResponse Registration(string authToken, string boxId, RegistrationRequest registrationRequest)
		{
			var builder = new PathAndQueryBuilder("/Registration");
			builder.AddParameter("boxId", boxId);

			return PerformHttpRequest<RegistrationRequest, RegistrationResponse>(
				authToken,
				builder.BuildPathAndQuery(),
				registrationRequest);
		}

		public void RegistrationConfirm(string authToken, string boxId, RegistrationConfirmRequest registrationConfirmRequest)
		{
			var builder = new PathAndQueryBuilder("/RegistrationConfirm");
			builder.AddParameter("boxId", boxId);

			PerformHttpRequest(
				authToken,
				"POST",
				builder.BuildPathAndQuery(),
				Serialize(registrationConfirmRequest));
		}
	}
}