CREATE TABLE ArticleSubContent(
	ArticleSubcontentId INT PRIMARY KEY,
	ArticleId INT NOT NULL, -- FK
	Title NVARCHAR(255),
	IsPublished BIT NOT NULL DEFAULT 0,
	IsDeleted BIT NOT NULL DEFAULT 0,
	PublishedTimeStamp DATETIME ,
	DeletedTimeStamp DATETIME  

)

ALTER TABLE ArticleSubContent
ADD CONSTRAINT FK_ArticleSubContent_Article FOREIGN KEY (ArticleId) REFERENCES Article(ArticleId)