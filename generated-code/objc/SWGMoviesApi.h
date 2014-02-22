#import <Foundation/Foundation.h>
#import "NIKApiInvoker.h"
#import "SWGMovies.h"


@interface SWGMoviesApi: NSObject {

@private
    NSOperationQueue *_queue;
    NIKApiInvoker * _api;
}
@property(nonatomic, readonly) NSOperationQueue* queue;
@property(nonatomic, readonly) NIKApiInvoker* api;

-(void) addHeader:(NSString*)value forKey:(NSString*)key;

/**

 Get a recordset of movies based on a query parameter
 Use a plus sign between words in titles with multiple words
 @param q Movie name as a string
 */
-(void) getMoviesWithCompletionBlock :(NSString*) q 
        completionHandler: (void (^)(SWGMovies* output, NSError* error))completionBlock;

@end
