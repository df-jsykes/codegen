#import <Foundation/Foundation.h>
#import "NIKSwaggerObject.h"
#import "SWGApp.h"
#import "Integer.h"

@interface SWGAppGroupRequest : NIKSwaggerObject

@property(nonatomic) NSNumber* _id;
@property(nonatomic) NSString* name;
@property(nonatomic) NSString* description;
@property(nonatomic) NSArray* apps;
- (id) _id: (NSNumber*) _id
     name: (NSString*) name
     description: (NSString*) description
     apps: (NSArray*) apps;

- (id) initWithValues: (NSDictionary*)dict;
- (NSDictionary*) asDictionary;


@end

