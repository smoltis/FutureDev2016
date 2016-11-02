// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DXNews.SDK
{
    using System.Threading.Tasks;
   using Models;

    /// <summary>
    /// Extension methods for DXNewsAPI.
    /// </summary>
    public static partial class DXNewsAPIExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static System.Collections.Generic.IList<NewsItem> GetNews(this IDXNewsAPI operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IDXNewsAPI)s).GetNewsAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IList<NewsItem>> GetNewsAsync(this IDXNewsAPI operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetNewsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}