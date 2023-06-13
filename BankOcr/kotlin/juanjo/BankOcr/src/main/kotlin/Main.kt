fun main() {
    println("Hello Kata!")

    getAccountNumber("|_| |")
}

fun getAccountNumber(zeroAccount: String): String {
    val accountLines = mutableListOf<String>()
    var item = ""
    for (i in 1..zeroAccount.length) {
        item += zeroAccount[i - 1]
        if (i == 27 || i == 54 || i == 81) {
            accountLines.add(item)
            item = ""
        }
    }

    var number = ""
    val itemList = mutableListOf<String>()

    accountLines.forEach {
        for (i in 1..it.length) {
            number += it[i - 1]
            if (number.length == 3) {
                itemList.add(number)
                number = ""
            }
        }
    }

    return buildAccountNumber(itemList)
}

fun buildAccountNumber(itemList: MutableList<String>): String {
    val num1 = itemList[0] + itemList[9] + itemList[18]
    val num2 = itemList[1] + itemList[10] + itemList[19]
    val num3 = itemList[2] + itemList[11] + itemList[20]
    val num4 = itemList[3] + itemList[12] + itemList[21]
    val num5 = itemList[4] + itemList[13] + itemList[22]
    val num6 = itemList[5] + itemList[14] + itemList[23]
    val num7 = itemList[6] + itemList[15] + itemList[24]
    val num8 = itemList[7] + itemList[16] + itemList[25]
    val num9 = itemList[8] + itemList[17] + itemList[26]

    return transformNumber(num1).toString() +
            transformNumber(num2).toString() +
            transformNumber(num3).toString() +
            transformNumber(num4).toString() +
            transformNumber(num5).toString() +
            transformNumber(num6).toString() +
            transformNumber(num7).toString() +
            transformNumber(num8).toString() +
            transformNumber(num9).toString()
}

fun transformNumber(accountDigit: String): Int? {
    when (accountDigit) {
        Numbers.NUMBER0.value -> return 0
        Numbers.NUMBER1.value -> return 1
        Numbers.NUMBER2.value -> return 2
        Numbers.NUMBER3.value -> return 3
        Numbers.NUMBER4.value -> return 4
        Numbers.NUMBER5.value -> return 5
        Numbers.NUMBER6.value -> return 6
        Numbers.NUMBER7.value -> return 7
        Numbers.NUMBER8.value -> return 8
        Numbers.NUMBER9.value -> return 9
    }
    return null
}

enum class Numbers(val value: String) {
    NUMBER0(" _ | ||_|"),
    NUMBER1("     |  |"),
    NUMBER2(" _  _||_ "),
    NUMBER3(" _  _| _|"),
    NUMBER4("   |_|  |"),
    NUMBER5(" _ |_  _|"),
    NUMBER6(" _ |_ |_|"),
    NUMBER7(" _   |  |"),
    NUMBER8(" _ |_||_|"),
    NUMBER9(" _ |_| _|")
}