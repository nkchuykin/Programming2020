using System;

public static class PermissionBuilder
{
    public static Permissions FromName(string permissionName)
    {
        switch (permissionName)
        {
            case "Default":
                return Permissions.Default;
            case "UserRead":
                return Permissions.UserRead;
            case "UserWrite":
                return Permissions.UserWrite;
            case "UserExecute":
                return Permissions.UserExecute;
            case "GroupRead":
                return Permissions.GroupRead;
            case "GroupWrite":
                return Permissions.GroupWrite;
            case "GroupExecute":
                return Permissions.GroupExecute;
            case "EveryoneRead":
                return Permissions.EveryoneRead;
            case "EveryoneWrite":
                return Permissions.EveryoneWrite;
            case "EveryoneExecute":
                return Permissions.EveryoneExecute;
            default:
                throw new NotImplementedException();
        }
    }
}