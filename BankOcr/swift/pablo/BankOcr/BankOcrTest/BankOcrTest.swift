//
//  BankOcrTest.swift
//  BankOcrTest
//
//  Created by Juanjo Martí on 12/6/23.
//

import XCTest

final class BankOcrTest: XCTestCase {

    func testZeroAccountNumber() throws {
        // GIVEN
        let bankAccount: String =   " _  _  _  _  _  _  _  _  _ " +
                                    "| || || || || || || || || |" +
                                    "|_||_||_||_||_||_||_||_||_|"
        // WHEN
        let account = parseBankAccount(bankAccount: bankAccount)
        
        // THEN
        XCTAssertEqual("000000000",account)
    }
    
    func test123456789AccountNumber() throws {
        // GIVEN
        let bankAccount: String = "    _  _     _  _  _  _  _ " +
                                  "  | _| _||_||_ |_   ||_||_|" +
                                  "  ||_  _|  | _||_|  ||_| _|"

        // WHEN
        let account = parseBankAccount(bankAccount: bankAccount)
        
        // THEN
        XCTAssertEqual("123456789",account)
        
    }
}
