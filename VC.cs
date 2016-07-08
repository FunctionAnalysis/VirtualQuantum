using Quantum;
using Quantum.Operations;
using System;
using System.Numerics;
using System.Collections.Generic;
namespace QuantumConsole
{public class QuantumTest
{public static void Main()
{
QuantumComputer comp = QuantumComputer.GetInstance();
Register x = comp.NewRegister(0, 4);
x.RotateX(3.14159265358979, 0);
x.RotateX(3.14159265358979, 0);
x.RotateX(3.14159, 1);
x.Measure(3);
x.InverseCPhaseShift(3, 0);
x.RotateX(1.5707963267949, 1);
x.RotateX(1.5708, 2);
x.Measure(3);
}
}
}
