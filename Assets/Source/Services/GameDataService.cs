using System.Threading.Tasks;
using WebStyleDemo.Models;

namespace WebStyleDemo.Services {
    /// <summary>
    /// Manages the game data
    /// </summary>
    public class GameDataService : IService {
        private const string BASE_URL = "SERVER-URL";

        // Singleton
        private static GameDataService instance;
        public static GameDataService Instance {
            get {
                if (instance == null) {
                    instance = new GameDataService ();
                }

                return instance;
            }
        }

        private GameData gameData;

        private GameDataService () { }

        /// <summary>
        /// Initializes the gameData, sync with server, etc...
        /// </summary>
        public void Initialize () {
            this.gameData = new GameData ();
        }

        /// <summary>
        /// Clears variables
        /// </summary>
        public void Dispose () {
            this.gameData = null;
        }

        public int Money { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        /// <summary>
        /// Fetches the gameData from server
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public Task<GameData> Fetch (string accessToken) {
            return HttpService.Instance.Get<GameData> (BASE_URL, accessToken);
        }

        /// <summary>
        /// Saves the gameData in server
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public Task Save (string accessToken) {
            return HttpService.Instance.Post (BASE_URL, gameData, accessToken);
        }
    }
}