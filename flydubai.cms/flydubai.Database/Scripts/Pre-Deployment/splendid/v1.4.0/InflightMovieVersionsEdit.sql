alter table InflightMovieVersions
add IsNewMovie bit

alter table InflightMovieVersions
add NewMovieSortOrder int

alter table InflightMovieVersions
add ImagePath nvarchar(max)

alter table InflightMovieVersions
add Image int

update [flydubai].[cms].[Pages]
set PageCode = 'inflight-entertainment-AllMovies-en'
where PageCode = 'inflight-entertainment-MoviesThisMonth-en'

update [flydubai].[cms].[Pages]
set PageCode = 'inflight-entertainment-AllMovies-ar'
where PageCode = 'inflight-entertainment-MoviesThisMonth-ar'


update [flydubai].[cms].[Pages]
set PageCode = 'inflight-entertainment-NewMovies-en'
where PageCode = 'inflight-entertainment-MoviesNextMonth-en'

update [flydubai].[cms].[Pages]
set PageCode = 'inflight-entertainment-NewMovies-ar'
where PageCode = 'inflight-entertainment-MoviesNextMonth-ar'


insert into [flydubai].[dbo].[MediaCategories]
(Name)
values
('ife-movie')
