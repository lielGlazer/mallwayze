

export class Location{
    locationId?:number;
    AxisX:number;
    Axisy:number;
    floor:number;

    constructor(x: number, y: number) {
        this.AxisX = x;
        this.Axisy = y;
        this.floor=1;
    }

}