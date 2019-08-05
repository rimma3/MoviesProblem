﻿using System;
using System.Collections.Generic;

namespace MovieProblem
{
    class Program
    {

        //To solve this challenge, you are required to write an HTTP GET method to retrieve information from a
        //movie database.
        //Function Description
        //Given a string substr, getMovieTitles must perform the following tasks:
        //1. Query https://jsonmock.hackerrank.com/api/movies/search/?Title=substr (replace
        //substr).
        //2. Initialize the titles array to store total string elements.Store the Title from each record
        //returned in the data field to the titles array.
        //3. Sort titles in ascending order and return it as your answer.
        //The query response from the website is a JSON response with the following five fields:
        //page : The current page.
        //per_page : The maximum number of results per page.
        //total : The total number of records in the search result.
        //total_pages : The total number of pages which must be queried to get all the results.
        //data : An array of JSON objects containing movie information
        //In order to get all results, you may have to make multiple page requests. To request a page by number,
        //your query should read https://jsonmock.hackerrank.com/api/movies/search/?
        //Title= substr & page = pageNumber, replacing substr and pageNumber .
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
       
           var response = getMovieTitlesAsync(s);

          foreach (var value in response)
            {
                Console.WriteLine( value);
            }
        }

        static string[] getMovieTitlesAsync(string substr)
        {
            List<string> movieTitles = new List<string>();
       
                
            return movieTitles.ToArray(); 
        }
    }
}
