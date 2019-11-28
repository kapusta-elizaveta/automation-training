package com.epam.ta.page;

import com.epam.ta.model.SearchQueryMain;
import com.epam.ta.model.User;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;
import org.openqa.selenium.support.PageFactory;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

public class MainPage extends AbstractPage
{
	private final By loginErrorMessage = By.xpath("//div[contains(text(),'.')]");
	private final By userName = By.xpath("//a[@class='js-name']");
	private final static String XPATH_FOR_SEARCH_BUTTON = "button[class='c0127']";
	private final static String XPATH_FOR_APARTMENT_BUTTON = "li.select-search-box__row[data-value='102168']";
	private final static String XPATH_FOR_PLUSS_APARTMENT = "c0138";
	private final static String XPATH_FOR_VISITORS_BUTTON = "//*[@id='root']/div/div[3]/div";
	private final static String XPATH_FOR_PLUSS_VISITORS = "c0137";
	private final static String XPATH_FOR__ARRVAL_DATE = "react-datepicker-wrapper";
	private final static String XPATH_FOR_DEPARTURE_DATE = "react-datepicker-wrapper";
	private final static String XPATH_FOR_NUMBER_DEPARTURE_DATE = "//*[@aria-label='day-23']";
	private final static String XPATH_FOR_NUMBER_ARRIVAL_DATE = "//*[@aria-label='day-23']";
	private final static String XPATH_FOR_CITY = "input.select-search-box__search[placeholder='Выберите отель AZIMUT']";
	private final static String XPATH_FOR_TITTLE_DISTANTION = "//*(@id=':0')/div/div/div[1]/div/div[1]";

	     @FindBy( className = "link-auth")
	public WebElement personalAccount;

        @FindBy(className = "js-login-canal-cab")
	public WebElement titlePersonalAccount;

        @FindBy(className ="js-hbi-login-fb")
	public WebElement faceBookPersonalAccount;

	@FindBy(className ="//input[@id='email']")
	public WebElement faceBookPersonalAccountEmail;

	@FindBy(className ="//input[@id='pass']")
	public WebElement faceBookPersonalAccountPassword;

	@FindBy(className ="//input[@id='u_0_0']")
	public WebElement faceBookPersonalAccountButton;

        @FindBy(className = XPATH_FOR__ARRVAL_DATE)
	public WebElement arrivalDate;

       @FindBy(xpath = XPATH_FOR_NUMBER_ARRIVAL_DATE)
	public WebElement numberArrivalDate;

        @FindBy(className = XPATH_FOR_DEPARTURE_DATE)
	public WebElement departureDate;

        @FindBy(xpath = "//*[@aria-label='day-23']")
	public WebElement numberDepartureDate;

        @FindBy(xpath = XPATH_FOR_VISITORS_BUTTON)
	public WebElement visitors;

        @FindBy(className = XPATH_FOR_PLUSS_VISITORS)
	public WebElement visitorsPlus;

        @FindBy(css = XPATH_FOR_CITY)
	public WebElement city;

        @FindBy(css = XPATH_FOR_APARTMENT_BUTTON)
	public WebElement apartmentTitle;

        @FindBy(className= XPATH_FOR_PLUSS_APARTMENT)
	public WebElement apartmentPlus;

        @FindBy(css = XPATH_FOR_SEARCH_BUTTON)
	public WebElement searchButton;

	private final String BASE_URL = "https://ostrovok.ru/?sid=e3f58065-543e-4e70-b30a-82a7d16d821b";

	private WebDriver driver;
	WebElement source;

	public MainPage(WebDriver driver)
	{
		super(driver);
		PageFactory.initElements(this.driver, this);
	}

	@Override
	public MainPage openPage()
	{
		driver.navigate().to(BASE_URL);
		return this;
	}

	public void loginEntry(User user)
	{
		personalAccount.click();
		titlePersonalAccount.click();
		faceBookPersonalAccount.click();
		faceBookPersonalAccountEmail.sendKeys(user.getEmail());
		faceBookPersonalAccountPassword.sendKeys(user.getPassword());
		faceBookPersonalAccountButton.click();
	}

	public MainPage inputLogin(User user)
	{
		loginEntry(user);
		return new MainPage(driver);
	}

	public String getLoggedInEmail()
	{
		WebElement linkLoggedInUser = new WebDriverWait(driver, WAIT_TIMEOUT_SECONDS)
				.until(ExpectedConditions.presenceOfElementLocated(userName));
		return linkLoggedInUser.getText();
	}
	public String getLoginErrorMessage()
	{
		WebElement linkLoginErrorMessage = new WebDriverWait(driver, WAIT_TIMEOUT_SECONDS)
				.until(ExpectedConditions.presenceOfElementLocated(loginErrorMessage));
		return linkLoginErrorMessage.getText();
	}

	public SearchResultPage searchHotelsByParameters(SearchQueryMain query) {
		city.click();
		arrivalDate.click();
		new WebDriverWait(driver, WAIT_TIMEOUT_SECONDS).until(ExpectedConditions.presenceOfElementLocated(By.xpath(XPATH_FOR_TITTLE_DISTANTION)));
		numberArrivalDate.sendKeys(query.getArrivalDate());
		new WebDriverWait(driver, WAIT_TIMEOUT_SECONDS).until(ExpectedConditions.presenceOfElementLocated(By.xpath(XPATH_FOR_NUMBER_DEPARTURE_DATE)));
		numberDepartureDate.sendKeys(query.getDepartureDate());
		visitors.click();
		visitorsPlus.sendKeys(query.getRoomsNumber());
        apartmentTitle.click();
        apartmentPlus.click();
		searchButton = new WebDriverWait(driver, WAIT_TIMEOUT_SECONDS).until(ExpectedConditions.elementToBeClickable(By.xpath(XPATH_FOR_SEARCH_BUTTON)));
		searchButton.click();
		return new SearchResultPage(driver, query);
	}

	public MainPage findHotelsByIncorrectParameters(SearchQueryMain query) {
		city.click();
		arrivalDate.click();
		new WebDriverWait(driver, WAIT_TIMEOUT_SECONDS).until(ExpectedConditions.presenceOfElementLocated(By.xpath(XPATH_FOR_TITTLE_DISTANTION)));
		numberArrivalDate.sendKeys(query.getArrivalDate());
		new WebDriverWait(driver, WAIT_TIMEOUT_SECONDS).until(ExpectedConditions.presenceOfElementLocated(By.xpath(XPATH_FOR_NUMBER_DEPARTURE_DATE)));
		numberDepartureDate.sendKeys(query.getDepartureDate());
		searchButton = new WebDriverWait(driver, WAIT_TIMEOUT_SECONDS).until(ExpectedConditions.elementToBeClickable(By.xpath(XPATH_FOR_SEARCH_BUTTON)));
		searchButton.click();
		return new MainPage(driver);
	}

	public String errorMessage(){

		return this.errorMessage.getText();
	}

}

