namespace RoyalCode.Yasamen.Demos.Wasm.Models;

public class WarehouseNumbers
{
    public WarehouseNumbers() { }

    public WarehouseNumbers(string distributionCenterNumber)
    {
        DistributionCenterNumber = distributionCenterNumber;
    }

    public WarehouseNumbers(string distributionCenterNumber, string warehouseNumber)
    {
        DistributionCenterNumber = distributionCenterNumber;
        WarehouseNumber = warehouseNumber;
    }

    public string DistributionCenterNumber { get; set; }

    public string WarehouseNumber { get; set; }
}

public class AreaNumbers : WarehouseNumbers
{
    public AreaNumbers() { }

    public AreaNumbers(WarehouseNumbers warehouseNumbers) 
        : base(warehouseNumbers.DistributionCenterNumber, warehouseNumbers.WarehouseNumber) { }

    public AreaNumbers(WarehouseNumbers warehouseNumbers, string areaNumber) 
        : base(warehouseNumbers.DistributionCenterNumber, warehouseNumbers.WarehouseNumber)
    {
        AreaNumber = areaNumber;
    }

    public string AreaNumber { get; set; }
}