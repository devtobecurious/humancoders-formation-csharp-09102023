using MesInterfaces;

namespace AppelInterfaces01;

internal class PersonLambda
{
}


public class VipAttribute : Attribute
{

}

public class LambdaAttribute<T> : Attribute
{

}


[Vip]
[Lambda<string>]
internal class PersonPrivilegie : IVIP
{
}
