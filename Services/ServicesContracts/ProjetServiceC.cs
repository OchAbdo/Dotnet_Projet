﻿using Projet.Models;

namespace Projet.Services.ServicesContracts
{
    public interface ProjetServiceC
    {
        public Task AddProject(Project projet);
        public Task<IEnumerable<Project>> GetAllProjet();
        public Task<Project> GetProjetByid(long id);
        public void UpdateProjet(Project projet);
        public Task DeleteProjetAsync(long id);

    }
}
