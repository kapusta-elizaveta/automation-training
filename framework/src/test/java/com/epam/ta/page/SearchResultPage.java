package com.epam.ta.page;

import com.epam.ta.model.SearchQueryMain;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.PageFactory;

public class SearchResultPage extends AbstractPage{

    private WebDriver driver;
    private SearchQueryMain query;

    private WebElement arrivalDateInputSearch;

    public SearchResultPage(WebDriver driver, SearchQueryMain query) {
        super(driver);
        this.query = query;
        PageFactory.initElements(driver, this);
    }

    @Override
    public SearchResultPage openPage() {

        return this;
    }
}
