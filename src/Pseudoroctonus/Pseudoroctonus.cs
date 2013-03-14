using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Pug.Bizcotty;
using Pug.Bizcotty.Geography;

using Cartage = Pug.Cartage;
using Sisca = Pug.Sisca;
using Pug.Scorpion;

using Pug.Application.Data;
using Pug.Application.Security;

namespace Pug.Scopion.Pseudoroctonus
{
	public class Pseudoroctonus<Pi, Pp> : IScorpion<Pi,Pp>
		where Pi : Sisca.IProductInfo
		where Pp : Sisca.IProductInfoProvider<Pi>
	{
		ISecurityManager securityManager;

		//IApplicationData<ICartInfoStoreProvider> cartStoreProviderFactory;
		//Cartage.ICartage cartage;
		//Pp productInfoProvider;
		Sisca.ISisca<Pi, Pp> sisca;

		IScorpionDataProviderFactory dataProviderFactory;
		
		SynchronizationContext synchronizationContext = new SynchronizationContext();

		public Pseudoroctonus(Sisca.ISisca<Pi, Pp> sisca, IScorpionDataProviderFactory dataProviderFactory, ISecurityManager securityManager)
		{
			this.securityManager = securityManager;
			//this.cartStoreProviderFactory = cartStoreProviderFactory;
			this.dataProviderFactory = dataProviderFactory;
			//this.productInfoProvider = productInfoProvider;

			//cartage = new Cartage.Cartage<ICartInfoStoreProvider>(cartStoreProviderFactory, securityManager);

			//sisca = new Sisca.Sisca<ICartInfoStoreProvider, Pi, Pp>(cartage, productInfoProvider);
			this.sisca = sisca;
		}

		string GetNewIdentifier(object sync)
		{
			byte[] binarySeed;

			lock (sync)
			{
				binarySeed = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
			}

			string newIdentifier = Pug.Base32.From(binarySeed).Replace("=", "");

			return newIdentifier;
		}

		string GetNewOrderIdentifier()
		{
			return GetNewIdentifier(synchronizationContext.OrderIdentifierSync);
		}

		public void CreateOrder(ref string identifier, string cart, string buyerName, Address buyerAddress, Bizcotty.PersonName buyerContactPerson, string payerName, Address billingAddress, Bizcotty.PersonName billingContactPerson, decimal orderPriceTotal, decimal shippingCost, string buyerNote, string shippingName, Address shippingAddress, Bizcotty.PersonName shippingContactPerson, ICollection<ContactMethod> contactMethods, IDictionary<string, string> attributes)
		{
			throw new NotImplementedException();
		}

		public void CreateOrder(ref string identifier, string cart, string buyerName, Address buyerAddress, PersonName buyerContactPerson, string payerName, Address billingAddress, PersonName billingContactPerson, decimal orderPriceTotal, decimal shippingCost, string buyerNote, string shippingName, Address shippingAddress, PersonName shippingContactPerson, ICollection<ContactMethod> contactMethods, IDictionary<string, string> attributes, ref string paymentIdentifier, DateTime paymentTimestamp, string paymentMethod, string paymentTransactionIdentifier, string paymentTransactionType, string paymentStatus, string paymentStatusShortMessage, string paymentStatusLongMessage, string paymentType, string paymentCurrency, decimal paymentAmount, decimal paymentFee, decimal paymentFinalAmount, decimal paymentTaxAmount, decimal paymentExchangeRate, string paymentReceiptIdentifier, IDictionary<string, string> paymentAttributes)
		{
		}

		public IFulfillmentProcess GetFulfillmentProcess(string identifier)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<IFulfillmentProcessInfo> GetFulfillmentProcesses(string order, Range<DateTime> lastFulfillmentProcessRegistrationPeriod, Range<DateTime> lastFulfillmentProgressPeriod, string currentFulfillmentProgresssStatus, string currentFulfillmentProgressAssignee, Range<DateTime> expectedFulfillmentProcessCompletionTimestamp)
		{
			throw new NotImplementedException();
		}

		public IOrder GetOrder(string identifier)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Cartage.ICartInfo> GetOrders(string status, Range<DateTime> creationPeriod, string creationUser, Range<DateTime> lastModificationPeriod, string lastModificationUser)
		{
			throw new NotImplementedException();
		}

		public IPayment GetPayment(string identifier)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<IPaymentInfo> GetPayments(string order, Range<DateTime> period, string method, string paymentType, string status, string currency, string exchangeRate, Range<DateTime> registrationPeriod)
		{
			throw new NotImplementedException();
		}

		public void RegisterPayment(ref string identifier, string order, DateTime timestamp, string method, string transactionIdentifier, string transactionType, string status, string statusShortMessage, string statusLongMessage, string paymentType, string currency, decimal amount, decimal fee, decimal finalAmount, decimal taxAmount, decimal exchangeRate, string receiptIdentifier, IDictionary<string, string> attributes)
		{
			throw new NotImplementedException();
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
