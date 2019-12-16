package entity.plane;

import entity.Plane;
import enums.ExperimentalPlaneType;
import enums.PlaneClassificationLevel;

public class ExperimentalPlane extends Plane {

    private ExperimentalPlaneType experimentalPlaneType;
    private PlaneClassificationLevel planeClassificationLevel;

    public ExperimentalPlane(String model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity,
                             ExperimentalPlaneType type, PlaneClassificationLevel planeClassificationLevel) {
        super(model, maxSpeed, maxFlightDistance, maxLoadCapacity);
        this.experimentalPlaneType = experimentalPlaneType;
        this.planeClassificationLevel = planeClassificationLevel;
    }

    public PlaneClassificationLevel getPlaneClassificationLevel(){
        return planeClassificationLevel;
    }

    public void setPlaneClassificationLevel(PlaneClassificationLevel planeClassificationLevel){
        this.planeClassificationLevel = planeClassificationLevel;
    }

    @Override
    public boolean equals(Object o) {
        return super.equals(o);
    }

    @Override
    public int hashCode() {
        return super.hashCode();
    }

    @Override
    public String toString() {
        return "ExperimentalPlane{" +
                "experimentalPlaneType=" + experimentalPlaneType +
                '}';
    }
}
