package com.epam.ta.test;

import com.epam.ta.model.SearchQueryMain;
import com.epam.ta.page.MainPage;
import com.epam.ta.service.SearchQueryMainCreator;
import org.testng.annotations.Test;
import static org.hamcrest.MatcherAssert.assertThat;
import static org.hamcrest.Matchers.equalTo;
import static org.hamcrest.Matchers.is;

public class SearchPageTest extends CommonConditions{
    @Test
    public void searchHotelForLongStay()
    {
        SearchQueryMain testSearchQueryMain = SearchQueryMainCreator.withIncorrectCity();
        String textOfButtonToSubmitFormForLongStay = new MainPage(driver)
                .openPage()
                .findHotelsByIncorrectParameters(hotelTerms);
        assertThat(textOfButtonToSubmitFormForLongStay, is(equalTo("Неверный город")));
    }
}
