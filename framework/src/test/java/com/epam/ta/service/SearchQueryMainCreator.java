package com.epam.ta.service;

import com.epam.ta.model.SearchQueryMain;

public class SearchQueryMainCreator {

    public static final String TESTDATA_CITY = "testdata.searchQueryMain.place";
    public static final String TESTDATA_SEARCH_QUERY_MAIN_ROOMS_NUMBER = "testdata.searchQueryMain.roomsNumber";
    public static final String TESTDATA_SEARCH_QUERY_MAIN_NUMBER_ARRIVAL_DATE = "testdata.searchQueryMain.arrivalDate";
    public static final String TESTDATA_SEARCH_QUERY_MAIN_NUMBER_DEPARTURE_DATE = "testdata.searchQueryMain.departureDate";
    public static final String TESTDATA_SEARCH_QUERY_MAIN_NUMBER_VISITORS = "testdata.searchQueryMain.visitorsNumber";


    public static SearchQueryMain withIncorrectCity() {
        return new SearchQueryMain(TestDataReader.getTestData(TESTDATA_CITY),
                TestDataReader.getTestData(TESTDATA_SEARCH_QUERY_MAIN_ROOMS_NUMBER),
                TestDataReader.getTestData(TESTDATA_SEARCH_QUERY_MAIN_NUMBER_ARRIVAL_DATE),
                TestDataReader.getTestData(TESTDATA_SEARCH_QUERY_MAIN_NUMBER_DEPARTURE_DATE),
                TestDataReader.getTestData(TESTDATA_SEARCH_QUERY_MAIN_NUMBER_VISITORS));
    }
}
