package entity.plane;

import entity.Plane;
import enums.MilitaryPlaneType;

import java.util.Objects;

public class MilitaryPlane extends Plane {

    private MilitaryPlaneType militaryPlaneType;

    public MilitaryPlane(String model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity,
                         MilitaryPlaneType type) {
        super(model, maxSpeed, maxFlightDistance, maxLoadCapacity);
        this.militaryPlaneType = militaryPlaneType;
    }

    public MilitaryPlaneType getMilitaryPlaneType() {
        return militaryPlaneType;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        if (!super.equals(o)) return false;
        MilitaryPlane that = (MilitaryPlane) o;
        return militaryPlaneType == that.militaryPlaneType;
    }

    @Override
    public int hashCode() {
        return Objects.hash(super.hashCode(), militaryPlaneType);
    }

    @Override
    public String toString() {
        return "MilitaryPlane{" +
                "militaryPlaneType=" + militaryPlaneType +
                '}';
    }
}
