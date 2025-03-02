﻿namespace BridgePatternInConsole.Interfaces.Implementations;

// Each 'ConcreteImplementation' corresponds to a specific platform and
// implements the 'Implementation' interface using that platform's API.

public class ConcreteImplementationA : IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationA: The result in platform A.\n";
    }
}
