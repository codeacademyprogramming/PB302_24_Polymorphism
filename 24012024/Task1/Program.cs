using Task1;

Car[] cars = { new PetrolCar(), new ElectroCar(), new DiselCar(), new ElectroCar() };

Console.WriteLine(GetElecticCarCount(cars));



static uint GetElecticCarCount(Car[] cars)
{
    uint count = 0;

	for (int i = 0; i < cars.Length; i++)
	{
		if (cars[i] is ElectroCar)
			count++;
	}

	return count;
}