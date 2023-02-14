using DataAcces.Data;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Validators;

namespace MachineAPI
{
    public static class Api
    {
        public static void ConfigureApi(this WebApplication app)
        {
            //Endpoints
            app.MapGet(pattern: "/Machines", GetMachines);
            app.MapGet(pattern: "/Machines/{id}", GetMachine);
            app.MapPost(pattern: "/Machines", InsertMachine);
            app.MapPut(pattern: "/Machines", UpdateMachine);
            app.MapDelete(pattern: "/Machines", DeleteMachine);
            app.MapGet(pattern: "/Malfunctions", GetMalfunctions);
            app.MapPost(pattern: "/Malfunctions", InsertMalfunction);
            app.MapPut(pattern: "/Malfunctions", UpdateMalfunction);
            app.MapDelete(pattern: "/Malfunctions", DeleteMalfunction);
            app.MapPut(pattern: "/Malfunctions/Status", MalfunctionStatusChange);
            app.MapGet(pattern: "Malfunctions/GetSpecificNumber", GetSpecificNumberOfMalfunctions);
            app.MapGet(pattern: "Machines/GetAll_GetMalfunctions", GetAll_GetMalfunctions);
        }

        private static async Task<IResult> GetMachines(IMachineData data)
        {
            try
            {
                return Results.Ok(await data.GetMachines());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetMachine(int id, IMachineData data)
        {
            try
            {
                var results = await data.GetMachine(id);
                if (results == null) return Results.NotFound();
                return Results.Ok(results);
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> InsertMachine(MachineModel machine, IMachineData data)
        {
            try
            {
                await data.InsertMachine(machine);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> UpdateMachine(MachineModel machine, IMachineData data)
        {
            try
            {
                await data.UpdateMachine(machine);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> DeleteMachine(int id, IMachineData data)
        {
            try
            {
                await data.DeleteMachine(id);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
        
       private static async Task<IResult> GetMalfunctions(IMalfunctionData malfunctionData)
       {
           try
           {
               return Results.Ok(await malfunctionData.GetMalfunctions());
           }
           catch (Exception ex)
           {
               return Results.Problem(ex.Message);
           }
       }


       private static async Task<IResult> InsertMalfunction(MalfunctionModel malfunction, IMalfunctionData malfunctionData)
       {
          
          
           try
           {
               await malfunctionData.InsertMalfunction(malfunction);
               return Results.Ok();
           }
           catch (Exception ex)
           {
               return Results.Problem(ex.Message);
           }
       }

       private static async Task<IResult> UpdateMalfunction(MalfunctionModel malfunction, IMalfunctionData malfunctionData)
       {
           try
           {
               await malfunctionData.UpdateMalfunction(malfunction);
               return Results.Ok();
           }
           catch (Exception ex)
           {
               return Results.Problem(ex.Message);
           }
       }

       private static async Task<IResult> DeleteMalfunction(int id, IMalfunctionData malfunctionData)
       {
           try
           {
               await malfunctionData.DeleteMalfunction(id);
               return Results.Ok();
           }
           catch (Exception ex)
           {
               return Results.Problem(ex.Message);
           }
        }

        private static async Task<IResult> MalfunctionStatusChange(int id, string status, IMalfunctionData malfunctionData)
        {
            try
            {
                await malfunctionData.ChangeStatus(id,status);
                return Results.Ok();
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetSpecificNumberOfMalfunctions(IMalfunctionData malfunctionData)
        {
            try
            {
                return Results.Ok(await malfunctionData.GetSpecificNumberOfMalfunctions());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetAll_GetMalfunctions(IFullMachineData fullMachineData)
        {
            try
            {
                return Results.Ok(await fullMachineData.GetAll_GetMalfunctions());
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
