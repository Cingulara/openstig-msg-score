using openrmf_msg_score.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace openrmf_msg_score.Data {
    public interface IScoreRepository
    {
        Task<IEnumerable<Score>> GetAllScores();
        Task<Score> GetScore(string id);

        // query after multiple parameters
        Task<IEnumerable<Score>> GetScore(string bodyText, DateTime updatedFrom, long headerSizeLimit);

        // send back the score based on the checklist artifact Id
        Task<Score> GetScorebyArtifact(string artifactId);

        // add new note document
        Task<Score> AddScore(Score item);

        // remove a single document
        Task<bool> RemoveScore(ObjectId id);

        // update just a single document
        Task<bool> UpdateScore(Score body);

    }
}