package com.epam.ta.model;

import java.util.Objects;

public class SearchQueryMain {

    private String city;
    private String arrivalDate;
    private String departureDate;
    private String roomsNumber;
    private String visitorsNumber;


    public SearchQueryMain(String city, String arrivalDate, String departureDate, String roomsNumber, String visitorsNumber) {
        this.city = city;
        this.arrivalDate = arrivalDate;
        this.departureDate = departureDate;
        this.roomsNumber = roomsNumber;
        this.visitorsNumber = visitorsNumber;
    }

    public String getCity() {
        return city;
    }

    public void setCity(String city) {
        this.city = city;
    }

    public String getArrivalDate() {
        return arrivalDate;
    }

    public void setArrivalDate(String arrivalDate) {
        this.arrivalDate = arrivalDate;
    }

    public String getDepartureDate() {

        return departureDate;
    }

    public void setDepartureDate(String departureDate) {

        this.departureDate = departureDate;
    }

    public String getRoomsNumber() {

        return roomsNumber;
    }

    public void setRoomsNumber(String roomsNumber)
    {

        this.roomsNumber = roomsNumber;
    }

    public String getVisitorsNumber() {
        return visitorsNumber;
    }

    public void setVisitorsNumber(String visitorsNumber) {
        this.visitorsNumber = visitorsNumber;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        SearchQueryMain that = (SearchQueryMain) o;
        return Objects.equals(city, that.city) &&
                Objects.equals(arrivalDate, that.arrivalDate) &&
                Objects.equals(departureDate, that.departureDate) &&
                Objects.equals(roomsNumber, that.roomsNumber) &&
                Objects.equals(visitorsNumber, that.visitorsNumber);
    }

    @Override
    public int hashCode() {
        return Objects.hash(city, arrivalDate, departureDate, roomsNumber, visitorsNumber);
    }

    @Override
    public String toString() {
        return "SearchQueryMain{" +
                "place='" + city + '\'' +
                ", arrivalDate='" + arrivalDate + '\'' +
                ", departureDate='" + departureDate + '\'' +
                ", roomsNumber='" + roomsNumber + '\'' +
                ", visitorsNumber='" + visitorsNumber + '\'' +
                '}';
    }
}
