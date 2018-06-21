using FluentAssertions.Primitives;
using FluentAssertions.Execution;
using System.Web.Mvc;
using System.Diagnostics;

namespace FluentAssertions.Mvc
{
    /// <summary>
    /// Contains a number of methods to assert that an <see cref="ActionResult"/> is in the expected state.
    /// </summary>
    [DebuggerNonUserCode]
	public class ActionResultAssertions : ObjectAssertions
	{
        /// <summary>
        /// Contains fixed values used in assertions
        /// </summary>
        public struct Constants
        {
            /// <summary>
            /// A shared failure message
            /// </summary>
            public const string CommonFailMessage = "Expected ActionResult to be {0}{reason}, but found {1}";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ActionResultAssertions" /> class.
        /// </summary>
		public ActionResultAssertions (ActionResult subject) : base(subject)
		{
			Subject = subject;
		}

        /// <summary>
        /// Asserts that the subject is a <see cref="ContentResult"/>.
        /// </summary>
        public ContentResultAssertions BeContentResult()
        {
            return BeContentResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="ContentResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <paramref name="reason"/>.
        /// </param>
        public ContentResultAssertions BeContentResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                    .BecauseOf(reason, reasonArgs)
                    .ForCondition(Subject is ContentResult)
                    .FailWith(Constants.CommonFailMessage, typeof(ContentResult).Name, Subject.GetType().Name);

            return new ContentResultAssertions(Subject as ContentResult);
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="EmptyResult"/>.
        /// </summary>
        public EmptyResult BeEmptyResult()
        {
            return BeEmptyResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is an <see cref="EmptyResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <paramref name="reason"/>.
        /// </param>
        public EmptyResult BeEmptyResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                    .BecauseOf(reason, reasonArgs)
                    .ForCondition(Subject is EmptyResult)
                    .FailWith(Constants.CommonFailMessage, typeof(EmptyResult).Name, Subject.GetType().Name);

            return Subject as EmptyResult;
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="RedirectToRouteResult"/>.
        /// </summary>
        public RedirectToRouteAssertions BeRedirectToRouteResult()
        {
            return BeRedirectToRouteResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="RedirectToRouteResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <paramref name="reason"/>.
        /// </param>
        public RedirectToRouteAssertions BeRedirectToRouteResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                    .BecauseOf(reason, reasonArgs)
                    .ForCondition(Subject is RedirectToRouteResult)
                    .FailWith(Constants.CommonFailMessage, typeof(RedirectToRouteResult).Name, Subject.GetType().Name);

            return new RedirectToRouteAssertions(Subject as RedirectToRouteResult);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="PartialViewResult"/>.
        /// </summary>
        public PartialViewResultAssertions BePartialViewResult()
        {
            return BePartialViewResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="PartialViewResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <paramref name="reason"/>.
        /// </param>
        public PartialViewResultAssertions BePartialViewResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                    .BecauseOf(reason, reasonArgs)
                    .ForCondition(Subject is PartialViewResult)
                    .FailWith(Constants.CommonFailMessage, typeof(PartialViewResult).Name, Subject.GetType().Name);

            return new PartialViewResultAssertions(Subject as PartialViewResult);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="RedirectResult"/>.
        /// </summary>
        public RedirectResultAssertions BeRedirectResult()
        {
            return BeRedirectResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="RedirectResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <paramref name="reason"/>.
        /// </param>
        public RedirectResultAssertions BeRedirectResult(string reason, params object[] reasonArgs)
        {
            Execute.Assertion
                    .BecauseOf(reason, reasonArgs)
                    .ForCondition(Subject is RedirectResult)
                    .FailWith(Constants.CommonFailMessage, "RedirectResult", Subject.GetType().Name);

            return new RedirectResultAssertions(Subject as RedirectResult);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="ViewResult"/>.
        /// </summary>
        public ViewResultAssertions BeViewResult()
        {
            return BeViewResult(string.Empty, null);
        }

        /// <summary>
        /// Asserts that the subject is a <see cref="ViewResult"/>.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <paramref name="reason"/>.
        /// </param>
        public ViewResultAssertions BeViewResult(string reason, params object[] reasonArgs)
		{
			Execute.Assertion
                    .BecauseOf(reason, reasonArgs)
					.ForCondition (Subject is ViewResult)
                    .FailWith(Constants.CommonFailMessage, "ViewResult", Subject.GetType().Name);
			
			return new ViewResultAssertions (Subject as ViewResult);
		}
	}
}
