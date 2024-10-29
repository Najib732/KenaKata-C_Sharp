create database Kenakata;
use Kenakata;



CREATE TABLE ProductRecords (
    ProductId VARCHAR(255),
    ProductName VARCHAR(255) NOT NULL,
    BuyingPrice DECIMAL(10, 2) NOT NULL,
    SellingPrice DECIMAL(10, 2) NOT NULL,
    StockQuantity DECIMAL(10, 2) NOT NULL,
    LastPurchasedQuantity DECIMAL(10, 2), -- Store last purchased quantity
    TotalBuyingBalance DECIMAL(10, 2) DEFAULT 0.00, -- Store total buying balance
    PurchaseCount INT DEFAULT 0, -- Count of purchases made
    LastPurchaseNumber INT DEFAULT 0, -- Last purchase number
    LastAddedBy VARCHAR(255), -- Who added the product last time
    PRIMARY KEY (ProductId, ProductName)  -- Composite primary key
);

select * from ProductRecords;
drop table ProductRecords;

CREATE TABLE SellRecorder (
    ProductId VARCHAR(255),
    ProductName VARCHAR(255) NOT NULL,
    TotalPiecesSelling DECIMAL(10, 2) DEFAULT 0.00, -- Total pieces sold
    TotalSellingPrice DECIMAL(10, 2) DEFAULT 0.00, -- Total selling price
    ExistedPieces DECIMAL(10, 2), -- Remaining stock after sale
    SellingTime  DECIMAL(10, 2), -- How many times the product has been sold
    SoldBy VARCHAR(255) DEFAULT 'Najib', -- Who sold the product, defaults to Najib
    PRIMARY KEY (ProductId, ProductName)
);

select * from SellRecorder;
drop table SellRecorder;



