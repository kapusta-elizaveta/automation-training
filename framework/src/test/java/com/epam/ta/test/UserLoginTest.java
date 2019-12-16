package com.epam.ta.test;
import com.epam.ta.model.User;
import com.epam.ta.page.MainPage;
import com.epam.ta.service.UserCreator;
import org.testng.annotations.Test;
import static com.epam.ta.util.StringUtils.LOGIN_ALLERT_MESSAGE;
import static org.hamcrest.MatcherAssert.assertThat;
import static org.hamcrest.Matchers.equalTo;
import static org.hamcrest.Matchers.is;

public class UserLoginTest extends CommonConditions {

    @Test
    public void notAllowLogin()
    {
        User testUser = UserCreator.loginWithIncorrectData();
        String allertMessage = new MainPage(driver)
                .openPage()
                .inputLogin(testUser)
                .getLoginErrorMessage();
        assertThat(allertMessage, is(equalTo(LOGIN_ALLERT_MESSAGE)));

    }

    @Test
    public void AllowLogin()
    {
        User testUser = UserCreator.loginWithCorrectData();
        String loggedInUserName = new MainPage(driver)
                .openPage()
                .inputLogin(testUser)
                .getLoggedInUserName();
        assertThat(loggedInUserName, is(equalTo(testUser.getEmail())));
    }


}
