#import <Foundation/Foundation.h>
#import "NIKSwaggerObject.h"
#import "SWGMovie.h"

@interface SWGMovies : NIKSwaggerObject

@property(nonatomic) NSArray* resource;
- (id) resource: (NSArray*) resource;

- (id) initWithValues: (NSDictionary*)dict;
- (NSDictionary*) asDictionary;


@end

