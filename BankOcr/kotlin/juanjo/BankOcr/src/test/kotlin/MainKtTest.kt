import org.junit.Assert.assertEquals
import org.junit.Test

class MainKtTest {

    @Test
    fun `Check Zero account number`() {
        val account000000000 =
            " _  _  _  _  _  _  _  _  _ " +
            "| || || || || || || || || |" +
            "|_||_||_||_||_||_||_||_||_|"

        val accountNumberValues = getAccountNumber(account000000000)
        assertEquals("000000000", accountNumberValues)
    }

    @Test
    fun `Check One account number`() {
        val account111111111 =
            "                           " +
            "  |  |  |  |  |  |  |  |  |" +
            "  |  |  |  |  |  |  |  |  |"

        val accountNumberValues = getAccountNumber(account111111111)
        assertEquals("111111111", accountNumberValues)
    }

    @Test
    fun `Check Two account number`() {
        val account222222222 =
            " _  _  _  _  _  _  _  _  _ " +
            " _| _| _| _| _| _| _| _| _|" +
            "|_ |_ |_ |_ |_ |_ |_ |_ |_ "

        val accountNumberValues = getAccountNumber(account222222222)
        assertEquals("222222222", accountNumberValues)
    }

    @Test
    fun `Check Three account number`() {
        val account333333333 =
            " _  _  _  _  _  _  _  _  _ " +
            " _| _| _| _| _| _| _| _| _|" +
            " _| _| _| _| _| _| _| _| _|"

        val accountNumberValues = getAccountNumber(account333333333)
        assertEquals("333333333", accountNumberValues)
    }

    @Test
    fun `Check Four account number`() {
        val account444444444 =
            "                           " +
            "|_||_||_||_||_||_||_||_||_|" +
            "  |  |  |  |  |  |  |  |  |"

        val accountNumberValues = getAccountNumber(account444444444)
        assertEquals("444444444", accountNumberValues)
    }

    @Test
    fun `Check Five account number`() {
        val account555555555 =
            " _  _  _  _  _  _  _  _  _ " +
            "|_ |_ |_ |_ |_ |_ |_ |_ |_ " +
            " _| _| _| _| _| _| _| _| _|"

        val accountNumberValues = getAccountNumber(account555555555)
        assertEquals("555555555", accountNumberValues)
    }

    @Test
    fun `Check Six account number`() {
        val account666666666 =
            " _  _  _  _  _  _  _  _  _ " +
            "|_ |_ |_ |_ |_ |_ |_ |_ |_ " +
            "|_||_||_||_||_||_||_||_||_|"

        val accountNumberValues = getAccountNumber(account666666666)
        assertEquals("666666666", accountNumberValues)
    }

    @Test
    fun `Check Seven account number`() {
        val account777777777 =
            " _  _  _  _  _  _  _  _  _ " +
            "  |  |  |  |  |  |  |  |  |" +
            "  |  |  |  |  |  |  |  |  |"

        val accountNumberValues = getAccountNumber(account777777777)
        assertEquals("777777777", accountNumberValues)
    }

    @Test
    fun `Check Eight account number`() {
        val account888888888 =
            " _  _  _  _  _  _  _  _  _ " +
            "|_||_||_||_||_||_||_||_||_|" +
            "|_||_||_||_||_||_||_||_||_|"

        val accountNumberValues = getAccountNumber(account888888888)
        assertEquals("888888888", accountNumberValues)
    }

    @Test
    fun `Check Nine account number`() {
        val account999999999 =
            " _  _  _  _  _  _  _  _  _ " +
            "|_||_||_||_||_||_||_||_||_|" +
            " _| _| _| _| _| _| _| _| _|"

        val accountNumberValues = getAccountNumber(account999999999)
        assertEquals("999999999", accountNumberValues)
    }

    @Test
    fun `Check All numbers account`() {
        val account123456789 =
            "    _  _     _  _  _  _  _ " +
            "  | _| _||_||_ |_   ||_||_|" +
            "  ||_  _|  | _||_|  ||_| _|"

        val accountNumberValues = getAccountNumber(account123456789)
        assertEquals("123456789", accountNumberValues)
    }
}