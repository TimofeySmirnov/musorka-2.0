using gEOMETRIA.Classes;

List<Chetirehygolnik> figyres = new List<Chetirehygolnik>();

Chetirehygolnik fig = new Chetirehygolnik();
fig.KeyboardInput();
fig.SidesCalculation();
fig.DiagonalsCalculation();
fig.Perimetr();
fig.Ploshad();

List<Paralelogram> paralelograms = new List<Paralelogram>();

Paralelogram par = new Paralelogram();
par.KeyboardInput();
par.SidesCalculation();
par.DiagonalsCalculation();

par.Perimetr();par.ugol();
par.sinugol();
par.Ploshad();

